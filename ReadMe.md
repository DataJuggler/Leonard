![Project Leonard – A Video Upscaler](https://raw.githubusercontent.com/DataJuggler/SharedRepo/master/Shared/Images/ProjectLeonard.png)

The name “Leonard” came from my brain's loose connections:

Vulkan ➜ Vulcan ➜ Spock ➜ Leonard Nimoy - Live Long And Prosper

Leonard is a free, C# open-source video upscaler.
⚠️ Platform Support: Leonard runs on Windows only. Leonard uses WinForms, FFmpeg, and Real-ESRGAN

# Features

Converts an MP4 into a sequence of PNG images using FFmpeg

Reassembles the upscaled images into a new MP4 using FFmpeg

Get Last Frame - This button is useful for creating continuing videos. This will open the image in your default 
image editor.

Leonard is designed for upsizing AI-generated videos, low-res exports, or any situation where a larger-size 
video is needed. It uses AI-based super-resolution — not basic pixel stretching.

## ✨ Features

* Converts an MP4 into a sequence of PNG images using **FFmpeg**

* Upscales each image using **Real-ESRGAN Vulkan**

* Reassembles the upscaled images into a new MP4 using **FFmpeg**

* Get Last Frame: useful for continuing videos where the first frame of the next video matches the last frame of the previous one

---

## 🏃‍♂️ Running Leonard

You’ve got two ways to run Leonard:

### 🔹 Install Version

Click **Releases** on the right side of this repo and download the latest installer.
Run it like any other Windows installer.

> ⚠️ You may get a “Windows protected your PC” warning. That’s expected for unsigned apps.
> Click **“More Info” → “Run Anyway”**, or run the source code version if you prefer.

### 🏃‍ Run the Source Code

The full solution is available here:

[https://github.com/DataJuggler/Leonard](https://github.com/DataJuggler/Leonard)

Developers can run the source code version of Leonard. 

Choose **one** of the following methods:

---

How to Clone the Project
You have a few options to get started:

1. Launch Visual Studio. From the Start Page, Click "Clone a repository" under Get started

Paste this URL when prompted:
https://github.com/DataJuggler/Leonard

Then click Clone.

2. Download ZIP
On GitHub, click the green Code button ➜ Download ZIP

After the download: Right-click the downloaded .zip file and select Properties

If you see a checkbox or button that says Unblock, check it

Click Apply, then OK

This step removes the Mark of the Web, which can prevent some files from running or building properly 
in Visual Studio.

Now right click the zip file and select -> 'Extract All'.

Open Leonard.sln in Visual Studio.

## Development Requirements

Make sure you have Visual Studio with the Desktop Development Workflow (WinForms/WPF) enabled
Leonard is a WinForms app. If you don't have WinForms enabled, in Programs and Features select
Visual Studio 2022 and then click 'Modify' or

Open the Visual Studio Installer

Click Modify on your current installation

Make sure .NET Desktop Development is checked

Click Modify to install it

---

## 🐢 Warning: Upscaling Is Slow

Leonard uses real AI-based image super-resolution. That means every frame of your video is treated like a 
standalone image and upscaled individually. If you have ever used Upscayl, the #1 opensource image upscaler,
then you can judge by how long that takes you for 1 image x the number of images.

Upscayl (no affiliation)
https://github.com/upscayl/upscayl

Leonard uses the same Vulkan upscaler RealERSGAN

Developer's Note: NuGet package DataJuggler.RealERSGAN is used by Leonard. I created a NuGet package
so this project will run the same for the source code version as the installed version and to simplify distribution.

The source for DataJuggler.RealERSGAN is available here:

https://github.com/DataJuggler/DataJuggler.RealESRGAN

A 6-second video at 30fps = **180 images**
A 60-second video = **1,800 images**

Depending on your GPU and selected model, each frame can take **1 to 15 seconds** to upscale.

### 🕒 Estimated Time to Upscale a 5-Minute Video (60 FPS)

| Time per Frame    | Total Frames | Estimated Duration |
|----------------|-------------------|----------------------|
| **1 second**     | 18,000          | ~5 hours                |
| **5 seconds**   | 18,000          | ~25 hours              |
| **10 seconds** | 18,000          | ~50 hours              |
| **15 seconds** | 18,000          | ~75 hours              |


For best results, start with **short clips (5–20 seconds)**

---

Developer's Note: NuGet package **DataJuggler.FFmpeg** is used by Leonard to convert videos to 
image sequences and reassemble them after upscaling, and Get Last Frame Feature.

Screenshot of Leonard (Note, the UI may change. I will try and keep this updated but forgive me if I don't)

<img src="https://github.com/DataJuggler/SharedRepo/blob/master/Shared/Images/Leonard.png?raw=true" width="542" height="428" alt="Leonard Icon" />


## Use Case 1: Convert To Image Sequence

## 🧭 Step 1: Select Your Source Video

Click the **Browse** button next to the Source Video field and choose the `.mp4` file you want to upscale.

## 📁 Step 2: Select Your Output Folder

## Options:

**Upscale Images**: If checked, after the .mp4 has been converted to an image sequence, the image will then be upscaled
using the selected model and size you have selected. 

As mentioned above, this will take a long time. Upscaling is slow. I have an RTX 3090 and an I9-12900K and I average
a few seconds or longer per image. The more images in your source video the longer this will take. 

## Custom Sizes

The app sets the Height and Width to 1920 to 1080, because that is what I use the most. If you don't want the videos
resized to a specific size, set either one or both the Height and Width to 0. If the Height and Width are not set, the video
will be upscaled 2x, 3x or 4x depending on the model you selected Larger images take longer, thus 2x is the default. 

⚠️Too big of images creates huge videos

If you do not use Custom Sizes (hence set a Height & Width) I had Windows tell my system was low on
memory playing a 660 meg 6 second video. I discovered it was 5120 x 2880 isize images. I have 128 gig of memory, 
so I can image what this would do to lesser systems. I recommend setting a height and width. 
**Use at your own risk if you don't set a height and width!**

**Create MP4** If checked, after the .mp4 has been converted to an image sequence, and optionally upscaled, 
the MP4 will be rendered. This is generally pretty fast (a few seconds to to 10 or 15 for longer videos)

## Trouble Shooting

Some AI videos have problems because they lack property meta data. I added a cleanse method in an attempt to fix this.
Most video editors are better at handling this, so if you have a problem open your video in your favorite video editor. 
I use Movavi. I open the video and export it to save. 

After the 'Convert To Image Sequence' finishes the app should proceed to Upscaling (if checked) and after updscaling
proceed to creating an mp4 (if checked). 

## Get Last Frame

Select or enter the path to the Source Video and click the Get Last Frame button. This method wil open your
video and extract the last frame, and then open that image in your default video editor

## Upscale

You can upsscale a directory without converting to image sequence first. Select the source directory.

Step 1: 📁 Select the Source Directory

Step 2: Select the Scale (2x, 3x or 4x)

Step 3: Select the Model (see the Model Guide below)

Step 4: (Optional yet recommended) Set the Height and Width

Step 5: Click the Upscale button.

Step 6: Wait - this is not fast.

# Model Guide

RealESRGAN includes several model types, each optimized for different kinds of images. Use the guide 
below to choose the best model for your needs.

    Standard (realesrgan-x4plus)

        The original and most balanced model. Best for general photos, videos, and realistic content.
    
    Anime (realesrgan-x4plus-anime)

        Designed for upscaling anime-style artwork, line art, and 2D illustrations with flat colors and 
        hard edges.
    
    Fast (realesrgan-x4fast)

        A lighter model for faster performance. Lower quality than Standard, but good for quick previews
        or processing large batches with lower resource requirements.
    
    Remacri (remacri)

        Produces sharp, contrasty output with less blurring. Great for enhancing detail in already sharp 
        images or text-heavy graphics.
    
    UltraSharp (ultrasharp)

        Prioritizes edge definition and texture clarity. Useful for upscaling small, blurry images where 
        detail matters most.
    
    UltraMix (ultramix_balanced)

        A hybrid model that balances sharpness, smoothness, and noise reduction. Good for real-world 
        photography and complex scenes with mixed content.


## 🎬 Rendering MP4

Use this section to create an MP4 video from a folder of PNG images.

### Fields

- **CRF (4–24)** *(lower is better)* – Controls video quality vs. file size  
- **Input Folder** – The folder containing your upscaled PNG images  
- **Output Folder** – The folder where the rendered `.mp4` will be saved  
- **File Name** – The name of the output video file (**must end in `.mp4`**)

### 🔘 Render MP4

Click **Render MP4** to convert the image sequence into a video using FFmpeg.  
The new MP4 will be saved in your selected **Output Folder**.

## ❓ Problems or Questions?

Feel free to [create an issue](https://github.com/DataJuggler/Leonard/issues) if you run into any problems  
or have a question about using Leonard.

---

🌟 **Worth the price?** If Leonard saved you time or headaches, consider [leaving a star](https://github.com/DataJuggler/Leonard) on the repo — it really helps!

## Credits

**Upscaling** would not be possible without:

Real-ESRGAN Vulkan by Xintao  
https://github.com/xinntao/Real-ESRGAN

**Video**

This project would not be possible without the incredible work of the FFmpeg team.

FFmpeg is a powerful multimedia framework used for video and audio processing. This 
project uses FFmpeg to extract frames, convert videos to image sequences, and 
reassemble videos. All video-related operations in this tool are powered by FFmpeg.

We do not modify or redistribute FFmpeg’s source. FFmpeg is included as a standalone 
executable, and all credit for its capabilities goes to the FFmpeg community.

FFmpeg is licensed under the GNU LGPL or GPL, depending on configuration.

Learn more at:  
<a href="https://ffmpeg.org/">https://ffmpeg.org/</a>  
<a href="https://github.com/FFmpeg/FFmpeg/blob/master/CREDITS">
FFmpeg contributor credits</a>

**Advanced Installer**

As always I want to thank Advanced Installer for giving me a license to give away free software. I cannot afford to buy an installer
to give away free code, so many thanks to Advanced Installer. My only perk for creating free code.

## Chat GPT

While I do pay $20 per month, Chat GPT did help me learn how to use Vulkan and FFmpeg in a few days. 
As much as I cuss at him, it's pretty neat to paste a lot of text and say 'Analyzie and Summarize'.

## Future Plans

I hope to add more video effects and feature soon. I have a graphics library (DataJuggler.PixelDatabase), so now that videos are just images I can do video 
editing. Something I have wanted to do for many years.

## Star begging

If you find this project useful, please leave a star.

Thanks!
