

#region using statements


#endregion

namespace Leonard
{

    #region class MainForm
    /// <summary>
    /// This class is the designer for the MainForm
    /// </summary>
    partial class MainForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private Label StatusLabel;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SourceVideoCountrol;
        private DataJuggler.Win.Controls.Button GetLastFrameButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl OutputFolderControl;
        private DataJuggler.Win.Controls.Button ConvertToImageSequenceButton;
        private DataJuggler.Win.Controls.ProgressBar Graph;
        private DataJuggler.Win.Controls.LabelCheckBoxControl UpscaleCheckBox;
        private DataJuggler.Win.Controls.LabelComboBoxControl ModelControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl WidthControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl HeightControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl CreateMP4CheckBox;
        private DataJuggler.Win.Controls.Objects.PanelExtender MP4Panel;
        private DataJuggler.Win.Controls.LabelTextBoxControl MP4FileNameControl;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl MP4OutputFolderControl;
        private DataJuggler.Win.Controls.Button RenderMP4Button;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl MP4InputFolderControl;
        #endregion
        
        #region Events
            
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
            /// <summary>
            ///  Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
        #endregion

        #region InitializeComponent()
        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            SourceVideoCountrol = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            GetLastFrameButton = new DataJuggler.Win.Controls.Button();
            OutputFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            ConvertToImageSequenceButton = new DataJuggler.Win.Controls.Button();
            Graph = new DataJuggler.Win.Controls.ProgressBar();
            StatusLabel = new Label();
            UpscaleCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            ModelControl = new DataJuggler.Win.Controls.LabelComboBoxControl();
            WidthControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            HeightControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            CreateMP4CheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            MP4Panel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            label1 = new Label();
            CRFControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            MP4InputFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            RenderMP4Button = new DataJuggler.Win.Controls.Button();
            MP4FileNameControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            MP4OutputFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            SideBar = new PictureBox();
            RenderMP4Timer = new System.Windows.Forms.Timer(components);
            UpscaleButton = new DataJuggler.Win.Controls.Button();
            UpscaleFolderControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            InfoLabel = new Label();
            TimeOutTimer = new System.Windows.Forms.Timer(components);
            AbortButton = new DataJuggler.Win.Controls.Button();
            AbortInfo = new Label();
            MP4Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SideBar).BeginInit();
            SuspendLayout();
            // 
            // SourceVideoCountrol
            // 
            SourceVideoCountrol.BackColor = Color.Transparent;
            SourceVideoCountrol.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            SourceVideoCountrol.ButtonColor = Color.LemonChiffon;
            SourceVideoCountrol.ButtonImage = (Image)resources.GetObject("SourceVideoCountrol.ButtonImage");
            SourceVideoCountrol.ButtonWidth = 48;
            SourceVideoCountrol.DarkMode = false;
            SourceVideoCountrol.DisabledLabelColor = Color.Empty;
            SourceVideoCountrol.Editable = true;
            SourceVideoCountrol.EnabledLabelColor = Color.Empty;
            SourceVideoCountrol.Filter = null;
            SourceVideoCountrol.Font = new Font("Calibri", 14F);
            SourceVideoCountrol.HideBrowseButton = false;
            SourceVideoCountrol.LabelBottomMargin = 0;
            SourceVideoCountrol.LabelColor = Color.LemonChiffon;
            SourceVideoCountrol.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            SourceVideoCountrol.LabelText = "Source Video:";
            SourceVideoCountrol.LabelTopMargin = 0;
            SourceVideoCountrol.LabelWidth = 136;
            SourceVideoCountrol.Location = new Point(81, 34);
            SourceVideoCountrol.Name = "SourceVideoCountrol";
            SourceVideoCountrol.OnTextChangedListener = null;
            SourceVideoCountrol.OpenCallback = null;
            SourceVideoCountrol.ScrollBars = ScrollBars.None;
            SourceVideoCountrol.SelectedPath = null;
            SourceVideoCountrol.Size = new Size(648, 32);
            SourceVideoCountrol.StartPath = null;
            SourceVideoCountrol.TabIndex = 0;
            SourceVideoCountrol.TextBoxBottomMargin = 0;
            SourceVideoCountrol.TextBoxDisabledColor = Color.Empty;
            SourceVideoCountrol.TextBoxEditableColor = Color.Empty;
            SourceVideoCountrol.TextBoxFont = new Font("Calibri", 14F);
            SourceVideoCountrol.TextBoxTopMargin = 0;
            SourceVideoCountrol.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // GetLastFrameButton
            // 
            GetLastFrameButton.BackColor = Color.Transparent;
            GetLastFrameButton.ButtonText = "Get Last Frame";
            GetLastFrameButton.FlatStyle = FlatStyle.Flat;
            GetLastFrameButton.ForeColor = Color.LemonChiffon;
            GetLastFrameButton.Location = new Point(473, 117);
            GetLastFrameButton.Margin = new Padding(4, 5, 4, 5);
            GetLastFrameButton.Name = "GetLastFrameButton";
            GetLastFrameButton.Size = new Size(159, 36);
            GetLastFrameButton.TabIndex = 1;
            GetLastFrameButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Glass;
            GetLastFrameButton.UseMnemonic = true;
            GetLastFrameButton.Click += GetLastFrameButton_Click;
            // 
            // OutputFolderControl
            // 
            OutputFolderControl.BackColor = Color.Transparent;
            OutputFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            OutputFolderControl.ButtonColor = Color.LemonChiffon;
            OutputFolderControl.ButtonImage = (Image)resources.GetObject("OutputFolderControl.ButtonImage");
            OutputFolderControl.ButtonWidth = 48;
            OutputFolderControl.DarkMode = false;
            OutputFolderControl.DisabledLabelColor = Color.Empty;
            OutputFolderControl.Editable = true;
            OutputFolderControl.EnabledLabelColor = Color.Empty;
            OutputFolderControl.Filter = null;
            OutputFolderControl.Font = new Font("Calibri", 14F);
            OutputFolderControl.HideBrowseButton = false;
            OutputFolderControl.LabelBottomMargin = 0;
            OutputFolderControl.LabelColor = Color.LemonChiffon;
            OutputFolderControl.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            OutputFolderControl.LabelText = "Output Folder:";
            OutputFolderControl.LabelTopMargin = 0;
            OutputFolderControl.LabelWidth = 136;
            OutputFolderControl.Location = new Point(81, 77);
            OutputFolderControl.Name = "OutputFolderControl";
            OutputFolderControl.OnTextChangedListener = null;
            OutputFolderControl.OpenCallback = null;
            OutputFolderControl.ScrollBars = ScrollBars.None;
            OutputFolderControl.SelectedPath = null;
            OutputFolderControl.Size = new Size(648, 32);
            OutputFolderControl.StartPath = null;
            OutputFolderControl.TabIndex = 2;
            OutputFolderControl.TextBoxBottomMargin = 0;
            OutputFolderControl.TextBoxDisabledColor = Color.Empty;
            OutputFolderControl.TextBoxEditableColor = Color.Empty;
            OutputFolderControl.TextBoxFont = new Font("Calibri", 14F);
            OutputFolderControl.TextBoxTopMargin = 0;
            OutputFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ConvertToImageSequenceButton
            // 
            ConvertToImageSequenceButton.BackColor = Color.Transparent;
            ConvertToImageSequenceButton.ButtonText = "Convert To Image Sequence";
            ConvertToImageSequenceButton.FlatStyle = FlatStyle.Flat;
            ConvertToImageSequenceButton.ForeColor = Color.LemonChiffon;
            ConvertToImageSequenceButton.Location = new Point(219, 117);
            ConvertToImageSequenceButton.Margin = new Padding(4, 5, 4, 5);
            ConvertToImageSequenceButton.Name = "ConvertToImageSequenceButton";
            ConvertToImageSequenceButton.Size = new Size(247, 36);
            ConvertToImageSequenceButton.TabIndex = 3;
            ConvertToImageSequenceButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Glass;
            ConvertToImageSequenceButton.UseMnemonic = true;
            ConvertToImageSequenceButton.Click += ConvertToImageSequenceButton_Click;
            // 
            // Graph
            // 
            Graph.BackColor = Color.DarkGray;
            Graph.BackgroundColor = Color.DarkGray;
            Graph.BorderStyle = BorderStyle.FixedSingle;
            Graph.ForeColor = Color.DodgerBlue;
            Graph.Location = new Point(101, 645);
            Graph.Margin = new Padding(4, 5, 4, 5);
            Graph.Maximum = 100;
            Graph.Name = "Graph";
            Graph.SetOverflowToMax = true;
            Graph.Size = new Size(758, 22);
            Graph.TabIndex = 4;
            Graph.Value = 0;
            Graph.Visible = false;
            // 
            // StatusLabel
            // 
            StatusLabel.ForeColor = Color.LemonChiffon;
            StatusLabel.Location = new Point(101, 619);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(758, 22);
            StatusLabel.TabIndex = 5;
            StatusLabel.Text = "Status:";
            // 
            // UpscaleCheckBox
            // 
            UpscaleCheckBox.BackColor = Color.Transparent;
            UpscaleCheckBox.CheckBoxHorizontalOffSet = 0;
            UpscaleCheckBox.CheckBoxVerticalOffSet = 4;
            UpscaleCheckBox.CheckChangedListener = null;
            UpscaleCheckBox.Checked = false;
            UpscaleCheckBox.Editable = true;
            UpscaleCheckBox.Font = new Font("Calibri", 12F);
            UpscaleCheckBox.LabelColor = Color.LemonChiffon;
            UpscaleCheckBox.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            UpscaleCheckBox.LabelText = "Upscale:";
            UpscaleCheckBox.LabelWidth = 112;
            UpscaleCheckBox.Location = new Point(745, 36);
            UpscaleCheckBox.Name = "UpscaleCheckBox";
            UpscaleCheckBox.Size = new Size(128, 28);
            UpscaleCheckBox.TabIndex = 6;
            UpscaleCheckBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ModelControl
            // 
            ModelControl.BackColor = Color.Transparent;
            ModelControl.ComboBoxLeftMargin = 1;
            ModelControl.ComboBoxText = "";
            ModelControl.ComoboBoxFont = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModelControl.Editable = true;
            ModelControl.Font = new Font("Calibri", 14F);
            ModelControl.HideLabel = false;
            ModelControl.LabelBottomMargin = 0;
            ModelControl.LabelColor = Color.LemonChiffon;
            ModelControl.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            ModelControl.LabelText = "Model:";
            ModelControl.LabelTopMargin = 0;
            ModelControl.LabelWidth = 136;
            ModelControl.List = null;
            ModelControl.Location = new Point(83, 261);
            ModelControl.Name = "ModelControl";
            ModelControl.SelectedIndex = -1;
            ModelControl.SelectedIndexListener = null;
            ModelControl.Size = new Size(360, 28);
            ModelControl.Sorted = true;
            ModelControl.Source = null;
            ModelControl.TabIndex = 8;
            ModelControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // WidthControl
            // 
            WidthControl.BackColor = Color.Transparent;
            WidthControl.BottomMargin = 0;
            WidthControl.Editable = true;
            WidthControl.Encrypted = false;
            WidthControl.Font = new Font("Calibri", 14F, FontStyle.Bold);
            WidthControl.Inititialized = true;
            WidthControl.LabelBottomMargin = 0;
            WidthControl.LabelColor = Color.LemonChiffon;
            WidthControl.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            WidthControl.LabelText = "Width:";
            WidthControl.LabelTopMargin = 0;
            WidthControl.LabelWidth = 136;
            WidthControl.Location = new Point(83, 301);
            WidthControl.MultiLine = false;
            WidthControl.Name = "WidthControl";
            WidthControl.OnTextChangedListener = null;
            WidthControl.PasswordMode = false;
            WidthControl.ScrollBars = ScrollBars.None;
            WidthControl.Size = new Size(196, 32);
            WidthControl.TabIndex = 9;
            WidthControl.TextBoxBottomMargin = 0;
            WidthControl.TextBoxDisabledColor = Color.LightGray;
            WidthControl.TextBoxEditableColor = Color.White;
            WidthControl.TextBoxFont = new Font("Calibri", 14F);
            WidthControl.TextBoxTopMargin = 0;
            WidthControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // HeightControl
            // 
            HeightControl.BackColor = Color.Transparent;
            HeightControl.BottomMargin = 0;
            HeightControl.Editable = true;
            HeightControl.Encrypted = false;
            HeightControl.Font = new Font("Calibri", 14F, FontStyle.Bold);
            HeightControl.Inititialized = true;
            HeightControl.LabelBottomMargin = 0;
            HeightControl.LabelColor = Color.LemonChiffon;
            HeightControl.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            HeightControl.LabelText = "Height:";
            HeightControl.LabelTopMargin = 0;
            HeightControl.LabelWidth = 72;
            HeightControl.Location = new Point(307, 302);
            HeightControl.MultiLine = false;
            HeightControl.Name = "HeightControl";
            HeightControl.OnTextChangedListener = null;
            HeightControl.PasswordMode = false;
            HeightControl.ScrollBars = ScrollBars.None;
            HeightControl.Size = new Size(136, 32);
            HeightControl.TabIndex = 10;
            HeightControl.TextBoxBottomMargin = 0;
            HeightControl.TextBoxDisabledColor = Color.LightGray;
            HeightControl.TextBoxEditableColor = Color.White;
            HeightControl.TextBoxFont = new Font("Calibri", 14F);
            HeightControl.TextBoxTopMargin = 0;
            HeightControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // CreateMP4CheckBox
            // 
            CreateMP4CheckBox.BackColor = Color.Transparent;
            CreateMP4CheckBox.CheckBoxHorizontalOffSet = 0;
            CreateMP4CheckBox.CheckBoxVerticalOffSet = 4;
            CreateMP4CheckBox.CheckChangedListener = null;
            CreateMP4CheckBox.Checked = false;
            CreateMP4CheckBox.Editable = true;
            CreateMP4CheckBox.Font = new Font("Calibri", 12F);
            CreateMP4CheckBox.LabelColor = Color.LemonChiffon;
            CreateMP4CheckBox.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            CreateMP4CheckBox.LabelText = "Create MP4:";
            CreateMP4CheckBox.LabelWidth = 112;
            CreateMP4CheckBox.Location = new Point(745, 79);
            CreateMP4CheckBox.Name = "CreateMP4CheckBox";
            CreateMP4CheckBox.Size = new Size(128, 28);
            CreateMP4CheckBox.TabIndex = 11;
            CreateMP4CheckBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MP4Panel
            // 
            MP4Panel.BackgroundImage = Properties.Resources.Gray2;
            MP4Panel.BackgroundImageLayout = ImageLayout.Stretch;
            MP4Panel.Controls.Add(label1);
            MP4Panel.Controls.Add(CRFControl);
            MP4Panel.Controls.Add(MP4InputFolderControl);
            MP4Panel.Controls.Add(RenderMP4Button);
            MP4Panel.Controls.Add(MP4FileNameControl);
            MP4Panel.Controls.Add(MP4OutputFolderControl);
            MP4Panel.Location = new Point(101, 398);
            MP4Panel.Name = "MP4Panel";
            MP4Panel.Size = new Size(758, 177);
            MP4Panel.TabIndex = 12;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.LemonChiffon;
            label1.Location = new Point(277, 16);
            label1.Name = "label1";
            label1.Size = new Size(336, 24);
            label1.TabIndex = 18;
            label1.Text = " Lower = better quality, slower, bigger file";
            // 
            // CRFControl
            // 
            CRFControl.BackColor = Color.Transparent;
            CRFControl.BottomMargin = 0;
            CRFControl.Editable = true;
            CRFControl.Encrypted = false;
            CRFControl.Font = new Font("Calibri", 14F, FontStyle.Bold);
            CRFControl.Inititialized = true;
            CRFControl.LabelBottomMargin = 0;
            CRFControl.LabelColor = Color.LemonChiffon;
            CRFControl.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            CRFControl.LabelText = "CRF (4-24):";
            CRFControl.LabelTopMargin = 0;
            CRFControl.LabelWidth = 136;
            CRFControl.Location = new Point(53, 14);
            CRFControl.MultiLine = false;
            CRFControl.Name = "CRFControl";
            CRFControl.OnTextChangedListener = null;
            CRFControl.PasswordMode = false;
            CRFControl.ScrollBars = ScrollBars.None;
            CRFControl.Size = new Size(214, 32);
            CRFControl.TabIndex = 17;
            CRFControl.TextBoxBottomMargin = 0;
            CRFControl.TextBoxDisabledColor = Color.LightGray;
            CRFControl.TextBoxEditableColor = Color.White;
            CRFControl.TextBoxFont = new Font("Calibri", 14F);
            CRFControl.TextBoxTopMargin = 0;
            CRFControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MP4InputFolderControl
            // 
            MP4InputFolderControl.BackColor = Color.Transparent;
            MP4InputFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            MP4InputFolderControl.ButtonColor = Color.LemonChiffon;
            MP4InputFolderControl.ButtonImage = (Image)resources.GetObject("MP4InputFolderControl.ButtonImage");
            MP4InputFolderControl.ButtonWidth = 48;
            MP4InputFolderControl.DarkMode = false;
            MP4InputFolderControl.DisabledLabelColor = Color.Empty;
            MP4InputFolderControl.Editable = true;
            MP4InputFolderControl.EnabledLabelColor = Color.Empty;
            MP4InputFolderControl.Filter = null;
            MP4InputFolderControl.Font = new Font("Calibri", 14F);
            MP4InputFolderControl.HideBrowseButton = false;
            MP4InputFolderControl.LabelBottomMargin = 0;
            MP4InputFolderControl.LabelColor = Color.LemonChiffon;
            MP4InputFolderControl.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            MP4InputFolderControl.LabelText = "Input Folder:";
            MP4InputFolderControl.LabelTopMargin = 0;
            MP4InputFolderControl.LabelWidth = 136;
            MP4InputFolderControl.Location = new Point(53, 52);
            MP4InputFolderControl.Name = "MP4InputFolderControl";
            MP4InputFolderControl.OnTextChangedListener = null;
            MP4InputFolderControl.OpenCallback = null;
            MP4InputFolderControl.ScrollBars = ScrollBars.None;
            MP4InputFolderControl.SelectedPath = null;
            MP4InputFolderControl.Size = new Size(648, 32);
            MP4InputFolderControl.StartPath = null;
            MP4InputFolderControl.TabIndex = 12;
            MP4InputFolderControl.TextBoxBottomMargin = 0;
            MP4InputFolderControl.TextBoxDisabledColor = Color.Empty;
            MP4InputFolderControl.TextBoxEditableColor = Color.Empty;
            MP4InputFolderControl.TextBoxFont = new Font("Calibri", 12F);
            MP4InputFolderControl.TextBoxTopMargin = 0;
            MP4InputFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // RenderMP4Button
            // 
            RenderMP4Button.BackColor = Color.Transparent;
            RenderMP4Button.ButtonText = "Render MP4";
            RenderMP4Button.FlatStyle = FlatStyle.Flat;
            RenderMP4Button.ForeColor = Color.LemonChiffon;
            RenderMP4Button.Location = new Point(521, 128);
            RenderMP4Button.Margin = new Padding(4, 5, 4, 5);
            RenderMP4Button.Name = "RenderMP4Button";
            RenderMP4Button.Size = new Size(180, 36);
            RenderMP4Button.TabIndex = 11;
            RenderMP4Button.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Glass;
            RenderMP4Button.UseMnemonic = true;
            RenderMP4Button.Click += RenderMP4Button_Click;
            // 
            // MP4FileNameControl
            // 
            MP4FileNameControl.BackColor = Color.Transparent;
            MP4FileNameControl.BottomMargin = 0;
            MP4FileNameControl.Editable = true;
            MP4FileNameControl.Encrypted = false;
            MP4FileNameControl.Font = new Font("Calibri", 14F, FontStyle.Bold);
            MP4FileNameControl.Inititialized = true;
            MP4FileNameControl.LabelBottomMargin = 0;
            MP4FileNameControl.LabelColor = Color.LemonChiffon;
            MP4FileNameControl.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            MP4FileNameControl.LabelText = "File Name:";
            MP4FileNameControl.LabelTopMargin = 0;
            MP4FileNameControl.LabelWidth = 136;
            MP4FileNameControl.Location = new Point(53, 134);
            MP4FileNameControl.MultiLine = false;
            MP4FileNameControl.Name = "MP4FileNameControl";
            MP4FileNameControl.OnTextChangedListener = null;
            MP4FileNameControl.PasswordMode = false;
            MP4FileNameControl.ScrollBars = ScrollBars.None;
            MP4FileNameControl.Size = new Size(414, 32);
            MP4FileNameControl.TabIndex = 10;
            MP4FileNameControl.TextBoxBottomMargin = 0;
            MP4FileNameControl.TextBoxDisabledColor = Color.LightGray;
            MP4FileNameControl.TextBoxEditableColor = Color.White;
            MP4FileNameControl.TextBoxFont = new Font("Calibri", 12F);
            MP4FileNameControl.TextBoxTopMargin = 0;
            MP4FileNameControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MP4OutputFolderControl
            // 
            MP4OutputFolderControl.BackColor = Color.Transparent;
            MP4OutputFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            MP4OutputFolderControl.ButtonColor = Color.LemonChiffon;
            MP4OutputFolderControl.ButtonImage = (Image)resources.GetObject("MP4OutputFolderControl.ButtonImage");
            MP4OutputFolderControl.ButtonWidth = 48;
            MP4OutputFolderControl.DarkMode = false;
            MP4OutputFolderControl.DisabledLabelColor = Color.Empty;
            MP4OutputFolderControl.Editable = true;
            MP4OutputFolderControl.EnabledLabelColor = Color.Empty;
            MP4OutputFolderControl.Filter = null;
            MP4OutputFolderControl.Font = new Font("Calibri", 14F);
            MP4OutputFolderControl.HideBrowseButton = false;
            MP4OutputFolderControl.LabelBottomMargin = 0;
            MP4OutputFolderControl.LabelColor = Color.LemonChiffon;
            MP4OutputFolderControl.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            MP4OutputFolderControl.LabelText = "Output Folder:";
            MP4OutputFolderControl.LabelTopMargin = 0;
            MP4OutputFolderControl.LabelWidth = 136;
            MP4OutputFolderControl.Location = new Point(53, 93);
            MP4OutputFolderControl.Name = "MP4OutputFolderControl";
            MP4OutputFolderControl.OnTextChangedListener = null;
            MP4OutputFolderControl.OpenCallback = null;
            MP4OutputFolderControl.ScrollBars = ScrollBars.None;
            MP4OutputFolderControl.SelectedPath = null;
            MP4OutputFolderControl.Size = new Size(648, 32);
            MP4OutputFolderControl.StartPath = null;
            MP4OutputFolderControl.TabIndex = 7;
            MP4OutputFolderControl.TextBoxBottomMargin = 0;
            MP4OutputFolderControl.TextBoxDisabledColor = Color.Empty;
            MP4OutputFolderControl.TextBoxEditableColor = Color.Empty;
            MP4OutputFolderControl.TextBoxFont = new Font("Calibri", 12F);
            MP4OutputFolderControl.TextBoxTopMargin = 0;
            MP4OutputFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // SideBar
            // 
            SideBar.BackgroundImage = Properties.Resources.Sidebar;
            SideBar.BackgroundImageLayout = ImageLayout.Stretch;
            SideBar.Dock = DockStyle.Left;
            SideBar.Location = new Point(0, 0);
            SideBar.Name = "SideBar";
            SideBar.Size = new Size(72, 681);
            SideBar.TabIndex = 15;
            SideBar.TabStop = false;
            // 
            // RenderMP4Timer
            // 
            RenderMP4Timer.Interval = 2000;
            RenderMP4Timer.Tick += RenderMP4Timer_Tick;
            // 
            // UpscaleButton
            // 
            UpscaleButton.BackColor = Color.Transparent;
            UpscaleButton.ButtonText = "Upscale Folder";
            UpscaleButton.FlatStyle = FlatStyle.Flat;
            UpscaleButton.ForeColor = Color.LemonChiffon;
            UpscaleButton.Location = new Point(450, 257);
            UpscaleButton.Margin = new Padding(4, 5, 4, 5);
            UpscaleButton.Name = "UpscaleButton";
            UpscaleButton.Size = new Size(149, 36);
            UpscaleButton.TabIndex = 16;
            UpscaleButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Glass;
            UpscaleButton.UseMnemonic = true;
            UpscaleButton.Click += UpscaleButton_Click;
            // 
            // UpscaleFolderControl
            // 
            UpscaleFolderControl.BackColor = Color.Transparent;
            UpscaleFolderControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.Folder;
            UpscaleFolderControl.ButtonColor = Color.LemonChiffon;
            UpscaleFolderControl.ButtonImage = (Image)resources.GetObject("UpscaleFolderControl.ButtonImage");
            UpscaleFolderControl.ButtonWidth = 48;
            UpscaleFolderControl.DarkMode = false;
            UpscaleFolderControl.DisabledLabelColor = Color.Empty;
            UpscaleFolderControl.Editable = true;
            UpscaleFolderControl.EnabledLabelColor = Color.Empty;
            UpscaleFolderControl.Filter = null;
            UpscaleFolderControl.Font = new Font("Calibri", 14F);
            UpscaleFolderControl.HideBrowseButton = false;
            UpscaleFolderControl.LabelBottomMargin = 0;
            UpscaleFolderControl.LabelColor = Color.LemonChiffon;
            UpscaleFolderControl.LabelFont = new Font("Calibri", 14F, FontStyle.Bold);
            UpscaleFolderControl.LabelText = "Upscale Folder:";
            UpscaleFolderControl.LabelTopMargin = 0;
            UpscaleFolderControl.LabelWidth = 136;
            UpscaleFolderControl.Location = new Point(83, 216);
            UpscaleFolderControl.Name = "UpscaleFolderControl";
            UpscaleFolderControl.OnTextChangedListener = null;
            UpscaleFolderControl.OpenCallback = null;
            UpscaleFolderControl.ScrollBars = ScrollBars.None;
            UpscaleFolderControl.SelectedPath = null;
            UpscaleFolderControl.Size = new Size(648, 32);
            UpscaleFolderControl.StartPath = null;
            UpscaleFolderControl.TabIndex = 17;
            UpscaleFolderControl.TextBoxBottomMargin = 0;
            UpscaleFolderControl.TextBoxDisabledColor = Color.Empty;
            UpscaleFolderControl.TextBoxEditableColor = Color.Empty;
            UpscaleFolderControl.TextBoxFont = new Font("Calibri", 14F);
            UpscaleFolderControl.TextBoxTopMargin = 0;
            UpscaleFolderControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // InfoLabel
            // 
            InfoLabel.BackColor = Color.Transparent;
            InfoLabel.ForeColor = Color.LemonChiffon;
            InfoLabel.Location = new Point(450, 310);
            InfoLabel.Name = "InfoLabel";
            InfoLabel.Size = new Size(369, 24);
            InfoLabel.TabIndex = 19;
            InfoLabel.Text = "Output Folder will be created in Upscale Folder";
            // 
            // AbortButton
            // 
            AbortButton.BackColor = Color.Transparent;
            AbortButton.ButtonText = "Abort";
            AbortButton.FlatStyle = FlatStyle.Flat;
            AbortButton.ForeColor = Color.LemonChiffon;
            AbortButton.Location = new Point(642, 117);
            AbortButton.Margin = new Padding(4, 5, 4, 5);
            AbortButton.Name = "AbortButton";
            AbortButton.Size = new Size(87, 36);
            AbortButton.TabIndex = 21;
            AbortButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Glass;
            AbortButton.UseMnemonic = true;
            AbortButton.Click += AbortButton_Click;
            // 
            // AbortInfo
            // 
            AbortInfo.BackColor = Color.Transparent;
            AbortInfo.ForeColor = Color.LemonChiffon;
            AbortInfo.Location = new Point(610, 158);
            AbortInfo.Name = "AbortInfo";
            AbortInfo.Size = new Size(151, 24);
            AbortInfo.TabIndex = 22;
            AbortInfo.Text = "(Close This App)";
            AbortInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Black;
            ClientSize = new Size(901, 681);
            Controls.Add(AbortInfo);
            Controls.Add(AbortButton);
            Controls.Add(InfoLabel);
            Controls.Add(UpscaleFolderControl);
            Controls.Add(UpscaleButton);
            Controls.Add(UpscaleCheckBox);
            Controls.Add(SideBar);
            Controls.Add(MP4Panel);
            Controls.Add(CreateMP4CheckBox);
            Controls.Add(HeightControl);
            Controls.Add(WidthControl);
            Controls.Add(ModelControl);
            Controls.Add(StatusLabel);
            Controls.Add(Graph);
            Controls.Add(ConvertToImageSequenceButton);
            Controls.Add(OutputFolderControl);
            Controls.Add(GetLastFrameButton);
            Controls.Add(SourceVideoCountrol);
            Font = new Font("Calibri", 14F);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leonard";
            Activated += MainForm_Activated;
            MP4Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)SideBar).EndInit();
            ResumeLayout(false);
        }

        #endregion
        #endregion
        private PictureBox SideBar;
        private Label label1;
        private DataJuggler.Win.Controls.LabelTextBoxControl CRFControl;
        private System.Windows.Forms.Timer RenderMP4Timer;
        private DataJuggler.Win.Controls.Button UpscaleButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl UpscaleFolderControl;
        private Label InfoLabel;
        private System.Windows.Forms.Timer TimeOutTimer;
        private DataJuggler.Win.Controls.Button AbortButton;
        private Label AbortInfo;
    }
    #endregion

}
