

#region using statements

using DataJuggler.PixelDatabase;
using DataJuggler.UltimateHelper;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;
using System.Diagnostics;
using System.IO;
using System.Runtime.Versioning;
using DataJuggler.FFmpeg;
using DataJuggler.RealESRGAN;
using DataJuggler.RealESRGAN.Enumerations;

#endregion

namespace Leonard
{

    #region class MainForm
    /// <summary>
    /// This class is the Main Form for this app
    /// </summary>
    [SupportedOSPlatform("windows")]
    public partial class MainForm : Form, ITextChanged
    {

        #region Private Variables
        private bool firstRender;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'Form1' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events

        #region AbortButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'AbortButton' is clicked.
        /// </summary>
        private void AbortButton_Click(object sender, EventArgs e)
        {
            // Forces exit
            Environment.Exit(0); // Forces process exit. No cleanup.
        }
        #endregion

        #region ConvertToImageSequenceButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'ConvertToImageSequenceButton' is clicked.
        /// </summary>
        private void ConvertToImageSequenceButton_Click(object sender, EventArgs e)
        {
            // Show a message
            ShowStatus("Starting...", Color.LemonChiffon);

            // is this valid
            bool isValid = ValidateConvertToImageSequence();

            // is everything valid
            if (isValid)
            {
                // set the path
                string path = SourceVideoCountrol.Text;

                // If the path Exists On Disk
                if (FileHelper.Exists(path))
                {
                    // Show a message
                    ShowStatus("Path Exists...", Color.LemonChiffon);

                    // Create a FileInfo to get just the fileName
                    FileInfo fileInfo = new FileInfo(path);

                    // replace out .mp4
                    string fileName = fileInfo.Name.Replace(".mp4", "");

                    // Set the outputPath
                    string outputPath = OutputFolderControl.Text;

                    // Show a message
                    ShowStatus("Converting MP4 to Image Sequence", Color.LemonChiffon);

                    // Star the timer
                    TimeOutTimer.Enabled = true;
                    TimeOutTimer.Start();

                    // convert the mp4 to an image sequence
                    bool converted = FFmpegHelper.ConvertToImageSequence(path, outputPath, Callback);

                    // Stop the timer
                    TimeOutTimer.Enabled = false;
                    TimeOutTimer.Stop();

                    // if successful 
                    if (converted)
                    {
                        // Show a message
                        ShowStatus("MP4 Converted to Image Sequence", Color.LemonChiffon);

                        // if Checked
                        if (UpscaleCheckBox.Checked)
                        {
                            // Upscale the images
                            UpscaleDirectory(outputPath);
                        }

                        // if checked
                        if (CreateMP4CheckBox.Checked)
                        {
                            // Start the Time
                            RenderMP4Timer.Enabled = true;
                            RenderMP4Timer.Start();
                        }

                        // Show a success message
                        ShowStatus("Status: Finished", Color.LemonChiffon);
                    }
                    else
                    {
                        // Show a failure message                    
                        ShowStatus("Status: Failed", Color.Tomato);
                    }
                }
                else
                {
                    // Show a failure message                    
                    ShowStatus("Status: Source video does not exist", Color.Tomato);
                }
            }
        }
        #endregion

        #region FixSizesButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'FixSizesButton' is clicked.
        /// </summary>
        private void FixSizesButton_Click(object sender, EventArgs e)
        {
            string path = @"c:\Temp\ImageSequence";
            List<string> files = FileHelper.GetFiles(path, ".png");

            // If the files collection exists and has one or more items
            if (ListHelper.HasOneOrMoreItems(files))
            {
                // Iterate the collection of string objects
                foreach (string file in files)
                {
                    // load
                    PixelDatabase pixelDatabase = PixelDatabaseLoader.LoadPixelDatabase(file, null);

                    // If the pixelDatabase object exists
                    if (NullHelper.Exists(pixelDatabase))
                    {
                        PixelDatabase resized = pixelDatabase.Resize(720, 1280);

                        File.Delete(file);

                        // now save
                        resized.SaveAs(file);
                    }
                }

                // show a message
                ShowStatus("Finished", Color.LemonChiffon);
            }
        }
        #endregion
        
        #region GetLastFrameButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'GetLastFrameButton' is clicked.
        /// </summary>
        private void GetLastFrameButton_Click(object sender, EventArgs e)
        {
            // set the path
            string path = SourceVideoCountrol.Text;

            // If the path Exists On Disk
            if (FileHelper.Exists(path))
            {
                // Create a FileInfo to get just the fileName
                FileInfo fileInfo = new FileInfo(path);

                // replace out .mp4
                string fileName = fileInfo.Name.Replace(".mp4", "");

                // Set the outputPath
                string outputPath = Path.Combine(OutputFolderControl.Text, "LastFrame_" + fileName + ".png");

                // In case there is more than one
                outputPath = FileHelper.CreateFileNameWithPartialGuid(outputPath, 12);

                // Extract last frame
                bool success = FFmpegHelper.ExtractLastFrame(path, outputPath);

                // if success
                if (success)
                {
                    if (FileHelper.Exists(outputPath))
                    {
                        // Start the process
                        ProcessStartInfo psi = new ProcessStartInfo(outputPath)
                        {
                            // launch the file to your default image editor
                            UseShellExecute = true
                        };

                        Process.Start(psi);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to extract last frame.", "Error");
                }
            }
            else
            {
                // Show it in red
                SourceVideoCountrol.TextBox.BackColor = Color.Tomato;

                // Show a message
                ShowStatus("Source Video MP4 is required", Color.Tomato);
            }
        }
        #endregion

        #region MainForm_Activated(object sender, EventArgs e)
        /// <summary>
        /// event is fired when Main Form _ Activated
        /// </summary>
        private void MainForm_Activated(object sender, EventArgs e)
        {
            // only do this once
            if (!firstRender)
            {
                UpscaleCheckBox.Checked = true;
                CreateMP4CheckBox.Checked = true;

                // Set to true
                firstRender = true;
            }
        }
        #endregion

        #region OnTextChanged(Control sender, string text)
        /// <summary>
        /// event is fired when On Text Changed
        /// </summary>
        public void OnTextChanged(Control sender, string text)
        {
            if (TextHelper.Exists(text))
            {
                // Set up the Text
                UpscaleFolderControl.Text = text;
                MP4InputFolderControl.Text = Path.Combine(text, "Upscaled1");
            }
        }
        #endregion

        #region RenderMP4Button_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'RenderMP4Button' is clicked.
        /// </summary>
        private void RenderMP4Button_Click(object sender, EventArgs e)
        {
            // Get the outputPath
            string outputPath = Path.Combine(MP4OutputFolderControl.Text, MP4FileNameControl.Text);

            // Create the MP4
            CreateMP4(MP4InputFolderControl.Text, outputPath);
        }
        #endregion

        #region RenderMP4Timer_Tick(object sender, EventArgs e)
        /// <summary>
        /// event is fired when Render MP 4 Timer _ Tick
        /// </summary>
        private void RenderMP4Timer_Tick(object sender, EventArgs e)
        {
            // Only run once
            RenderMP4Timer.Enabled = false;

            // Click the button
            RenderMP4Button_Click(this, null);
        }
        #endregion

        #region UpscaleButton_Click(object sender, EventArgs e)
        /// <summary>
        /// event is fired when the 'UpscaleButton' is clicked.
        /// </summary>
        private void UpscaleButton_Click(object sender, EventArgs e)
        {
            // Upscale the folder
            UpscaleDirectory(UpscaleFolderControl.Text);
        }
        #endregion

        #endregion

        #region Methods

        #region Callback(string senderName, string data)
        /// <summary>
        /// This method is used to receive data from FFmpegHelper or RealESRGANHelper
        /// </summary>
        public void Callback(string senderName, string data)
        {
            // for debugging only
            string temp = @"c:\Temp\Log.txt";

            // Test only
            File.AppendAllText(temp, data);
        }
        #endregion

        #region CreateMP4(string inputPath, string outputPath)
        /// <summary>
        /// Creates an MP4 for the directory of images in the outputPath
        /// </summary>
        public void CreateMP4(string inputPath, string outputPath)
        {
            // Show a message
            ShowStatus("Creating MP4...", Color.LemonChiffon);

            // Set the crt
            int crf = CRFControl.IntValue;

            // Create MP4 here
            bool success = FFmpegHelper.CreateMP4FromImages(inputPath, outputPath, Callback, crf);

            // if the MP4 was created
            if (success)
            {
                // Show a success message
                ShowStatus("Status: MP4 Finished", Color.LemonChiffon);
            }
            else
            {
                // Show a failure message
                ShowStatus("MP4 Creation Failed", Color.Tomato);
            }
        }
        #endregion

        #region FindAndCreateUpdatePath(string outputPath, List<string> folders)
        /// <summary>
        /// returns the And Create Update Path
        /// </summary>
        public string FindAndCreateUpdatePath(string outputPath, List<string> folders)
        {
            // initial value
            string path = "";

            // Get the highestUpscaled Folder, Upscaled1, Upscaled2, etc.
            int highestUpscaled = GetHighestUpscaledFolder(folders);

            // Add 1
            int upscaledFolderNumber = highestUpscaled + 1;

            // Now set the path
            path = Path.Combine(outputPath, "Upscaled" + upscaledFolderNumber);

            // Create the Path
            Directory.CreateDirectory(path);

            // return value
            return path;
        }
        #endregion

        #region GetHighestUpscaledFolder(List<stirng> folders)
        /// <summary>
        /// returns the Highest Upscaled Folder
        /// </summary>
        public int GetHighestUpscaledFolder(List<string> folders)
        {
            // initial value
            int highestUpscaled = 0;

            // If the folders collection exists and has one or more items
            if (ListHelper.HasOneOrMoreItems(folders))
            {
                // Iterate the collection of string objects
                foreach (string folder in folders)
                {
                    // Create a DirectoryInfo object
                    DirectoryInfo directoryInfo = new DirectoryInfo(folder);

                    // if this is an Upscaled folder
                    if (directoryInfo.Name.ToLower().StartsWith("upscaled"))
                    {
                        // Get the numeric part
                        string temp = directoryInfo.Name.ToLower().Replace("upscaled", "");

                        // Get the tempInt
                        int tempInt = NumericHelper.ParseInteger(temp, 0, -1);

                        // if the highest
                        if (tempInt > highestUpscaled)
                        {
                            // Set the highest
                            highestUpscaled = tempInt;
                        }
                    }
                }
            }

            // return value
            return highestUpscaled;
        }
        #endregion

        #region Init()
        /// <summary>
        ///  This method performs initializations for this object.
        /// </summary>
        public void Init()
        {
            // Setup the Listener & Check Upscale            
            OutputFolderControl.OnTextChangedListener = this;

            // Default Vlaues on my machine for testing. If left in, feel free to delete                        
            ModelControl.LoadItems(typeof(UpscaleModelEnum));
            ModelControl.SelectedIndex = ModelControl.FindItemIndexByValue("Standard");
            HeightControl.Text = "1080";
            WidthControl.Text = "1920";
            CRFControl.Text = "12";            
        }
        #endregion

        #region ParseModel(string modelText)
        /// <summary>
        /// returns the Model
        /// </summary>
        public UpscaleModelEnum ParseModel(string modelText)
        {
            // initial value
            UpscaleModelEnum model = UpscaleModelEnum.NotSet;

            // Determine the action by the modelText
            switch (modelText)
            {
                case "Standard":

                    // set the return value
                    model = UpscaleModelEnum.Standard;

                    // required
                    break;

                case "Anime":

                    // set the return value
                    model = UpscaleModelEnum.Anime;

                    // required
                    break;

                case "Fast":

                    // set the return value
                    model = UpscaleModelEnum.Fast;

                    // required
                    break;

                case "Remacri":

                    // set the return value
                    model = UpscaleModelEnum.Remacri;

                    // required
                    break;

                case "UltraSharp":

                    // set the return value
                    model = UpscaleModelEnum.UltraSharp;

                    // required
                    break;

                case "UltraMix":

                    // set the return value
                    model = UpscaleModelEnum.UltraMix;

                    // required
                    break;
            }

            // return value
            return model;
        }
        #endregion

        #region ShowStatus((string text, Color color))
        /// <summary>
        /// Showstatus
        /// </summary>
        public void ShowStatus(string text, Color color)
        {
            // Show a message
            StatusLabel.Text = text;
            StatusLabel.ForeColor = color;
            StatusLabel.Visible = true;
            Refresh();
            Application.DoEvents();
        }
        #endregion

        #region UpscaleDirectory(string directory, bool copyFirstFrameToLast = true)
        /// <summary>
        /// Upscale Directory
        /// </summary>
        public void UpscaleDirectory(string directory, bool copyFirstFrameToLast = true)
        {
            // Parse the Model
            UpscaleModelEnum model = ParseModel(ModelControl.ComboBoxText);

            try
            {
                // local
                int lastFrameNumber = 0;
                string temp = "";
                string firstFileName = "";

                // if the Folder exists on Disk
                if (FolderHelper.Exists(directory))
                {
                    // if a Model was selected
                    if (model != UpscaleModelEnum.NotSet)
                    {
                        // Get the png files out of the directory
                        List<string> files = FileHelper.GetFiles(directory, ".png");

                        // Get the directories
                        List<string> directories = FolderHelper.GetFolders(directory);

                        // First we need an output path (Upscaled1, Upscaled2, etc)
                        string outputFolder = FindAndCreateUpdatePath(directory, directories);

                        // If the files collection exists and has one or more items
                        if (ListHelper.HasOneOrMoreItems(files))
                        {
                            // Set the text
                            ShowStatus("Upscaling...", Color.LemonChiffon);

                            // Setup the Graph
                            Graph.Visible = true;
                            Graph.Maximum = files.Count;
                            Graph.Value = 0;

                            // get the name of the last file
                            string fileName = files[files.Count - 1];

                            // Create a fileInfo object for this file
                            FileInfo fileInfo = new FileInfo(fileName);

                            // get only the number
                            temp = fileInfo.Name.Replace("image", "").Replace(".png", "");

                            // parse the int
                            lastFrameNumber = NumericHelper.ParseInteger(temp, 0, -1);

                            // Iterate the collection of string objects
                            foreach (string file in files)
                            {
                                // Create a fileInfo object for this file
                                fileInfo = new FileInfo(file);

                                // set the outputPath
                                string outputPath = Path.Combine(outputFolder, fileInfo.Name);

                                // if the first file
                                if (Graph.Value == 0)
                                {
                                    // set the firstFileName
                                    firstFileName = outputPath;
                                }

                                // set the height and width
                                int height = HeightControl.IntValue;
                                int width = WidthControl.IntValue;

                                // Get the SelectedScale
                                // ScaleEnum scale = GetScale();

                                // Set the scale
                                ScaleEnum scale = ScaleEnum.Three_X;

                                // Upscale
                                bool success = RealESRGANHelper.UpscaleImage(file, outputPath, model, scale, height, width);

                                // Increment the value for Graph
                                Graph.Value++;

                                // refresh every 5 to go a little faster
                                if (Graph.Value % 5 == 0)
                                {
                                    // Refresh the UI
                                    Refresh();
                                    Application.DoEvents();
                                }
                            }

                            // if the value for copyFirstFrameToLast is true
                            if (copyFirstFrameToLast)
                            {
                                // get the newFileName
                                string newFileName = Path.Combine(outputFolder, "image" + (lastFrameNumber + 1) + ".png");

                                // copy the file
                                File.Copy(firstFileName, newFileName);
                            }

                            // Show a finished message
                            ShowStatus("Finished", Color.LemonChiffon);
                        }
                    }
                    else
                    {
                        // Show a finished message
                        ShowStatus("Could Not Parse Model", Color.Tomato);
                    }
                }
                else
                {
                    // Show the problem
                    UpscaleFolderControl.TextBox.BackColor = Color.Tomato;

                    // Show a finished message
                    ShowStatus("Input Folder Does Not Exist", Color.Tomato);
                }
            }
            catch (Exception error)
            {
                ShowStatus("Error: Upscale Failed", Color.Firebrick);

                // for debugging only
                DebugHelper.WriteDebugError("UpscaleDirectory", "MainForm", error);
            }
        }
        #endregion

        #region ValidateConvertToImageSequence()
        /// <summary>
        /// Validates Convert To Image Sequnce
        /// </summary>
        public bool ValidateConvertToImageSequence()
        {
            // initial value (default to true)
            bool isValid = true;

            // if it exists
            if (SourceVideoCountrol.HasText)
            {
                // if the path to the video exists on Text (should if selected, but if typed in could be wrong)
                if (FileHelper.Exists(SourceVideoCountrol.Text))
                {
                    // Show it in red
                    SourceVideoCountrol.TextBox.BackColor = Color.White;
                }
                else
                {
                    // set to false
                    isValid = false;

                    // Show it in red
                    SourceVideoCountrol.TextBox.BackColor = Color.Tomato;

                    // Show a message
                    ShowStatus("Source Video MP4 is required", Color.Tomato);
                }
            }
            else
            {
                // set to false
                isValid = false;

                // Show it in red
                SourceVideoCountrol.TextBox.BackColor = Color.Tomato;

                // Show a message
                ShowStatus("Source Video MP4 is required", Color.Tomato);
            }

            // if it exists and the previous validations passed
            if (isValid && OutputFolderControl.HasText)
            {
                // if the path to the folder exists
                if (FolderHelper.Exists(OutputFolderControl.Text))
                {
                    // Set to white to indicate OK
                    OutputFolderControl.TextBox.BackColor = Color.White;
                }
                else
                {
                    // set to false
                    isValid = false;

                    // Show it in red
                    OutputFolderControl.TextBox.BackColor = Color.Tomato;

                    // Show a message
                    ShowStatus("Output folder does not exist", Color.Tomato);
                }
            }
            else if (isValid) // only show this message if MP4 was valid
            {
                // set to false
                isValid = false;

                // Show it in red
                OutputFolderControl.TextBox.BackColor = Color.Tomato;

                // Show a message
                ShowStatus("Output folder is required", Color.Tomato);
            }

            // if isValid && Upscale is checked
            if (isValid && UpscaleCheckBox.Checked)
            {
                // if the folder does not exist
                if (!FolderHelper.Exists(UpscaleFolderControl.Text))
                {
                    // not valid
                    isValid = false;

                    // Show in red
                    UpscaleFolderControl.TextBox.BackColor = Color.Tomato;

                    // Show a message
                    ShowStatus("You have Upscale selected without an Upscale Folder selected", Color.Tomato);
                }
            }

            // if isValid && Create MP4 Is Checked
            if (isValid && CreateMP4CheckBox.Checked)
            {
                // if not in the 4 - 24 range
                if (!NumericHelper.IsInRange(CRFControl.IntValue, 4, 24))
                {
                    // not valid
                    isValid = false;

                    // Show in red
                    TextBox textBox = CRFControl.GetTextBox();

                    // Set the Backcolor
                    textBox.BackColor = Color.Tomato;

                    // Show a message
                    ShowStatus("You have Create MP4 Selected but do not have a valid CRF value set (4 - 24)", Color.Tomato);
                
                    // if still valid, but the MP4InputFolderControl folder does not exist or was not entered
                    if (isValid && !FolderHelper.Exists(MP4InputFolderControl.Text))
                    {
                         // not valid
                        isValid = false;

                        // Set to red
                        MP4InputFolderControl.TextBox.BackColor = Color.Tomato;

                        // Show a message
                        ShowStatus("You have Create MP4 Selected but do not have a valid MP4 Input Folder selected", Color.Tomato);
                    }

                    // if still valid, but the MP4InputFolderControl folder does not exist or was not entered
                    if (isValid && !FolderHelper.Exists(MP4OutputFolderControl.Text))
                    {
                         // not valid
                        isValid = false;

                        // Set to red                    
                        MP4OutputFolderControl.TextBox.BackColor = Color.Tomato;

                        // Show a message
                        ShowStatus("You have Create MP4 Selected but do not have a valid MP4 Output Folder selected", Color.Tomato);
                    }

                    // if still valid, but the MP4InputFolderControl folder does not exist or was not entered
                    if (isValid && !TextHelper.Exists(MP4FileNameControl.Text))
                    {
                         // not valid
                        isValid = false;

                        // Set to red
                        MP4FileNameControl.GetTextBox().BackColor = Color.Tomato;

                        // Show a message
                        ShowStatus("You have Create MP4 Selected but do not have a valid MP4 Filename entered", Color.Tomato);
                    }

                    // if still valid
                    if (isValid)
                    {
                        // set the FileInfo
                        FileInfo fileInfo = new FileInfo(MP4FileNameControl.Text);

                        // if the extion does not equal mp4
                        if (fileInfo.Extension != ".mp4")
                        {
                            // Set to red
                            MP4FileNameControl.GetTextBox().BackColor = Color.Tomato;

                            // Show a message
                            ShowStatus("The MP4 filename must end in .mp4", Color.Tomato);
                        }
                    }
                }
            }

            // return value
            return isValid;
        }
        #endregion

        #endregion
    }
    #endregion

}
