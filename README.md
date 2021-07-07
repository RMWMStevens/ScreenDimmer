# ScreenDimmer

A C# tray application that enables DisplayFusion-like screen dimming with only a fraction of the memory usage and no (what I consider) bloat.

For years I have used DisplayFusion to fulfill this singular task, but it has always annoyed me that it is paid software which makes activating it mandatory and makes using it on different user profiles in Windows a pain sometimes. Also, I don't use any other feature DisplayFusion offers and most of them are just annoying to me, so I have to painstakingly disable every single feature and just enable the one I use the whole software for. Also, I have Steam installed on my desktop but not my laptop and I don't want it there either, so dimming screens when working on multiple monitors (via Remote Desktop) is no option at all for me.

## Setup

Run the installer. Life can be so easy sometimes.

To change the ScreenDimmer hotkey, right-click the new tray icon. In the settings menu the default key combination of Ctrl + NumPeriod (NumDelete) can be changed to some preset hotkeys. This limits flexibility but for these combinations I could at least guarantee they actually work. If you want, you can have the application auto-start with Windows. The settings menu also allows for excluding full-screen displaying monitors if the user so wishes.

## Usage

When the app is running, you can click on the tray icon to dim your secondary screens. If activiting it by mouse isn't your thing, you can also use the hotkey to toggle dimming. It's that simple! 

---

### Disclaimer

This tool was only tested on Windows 10 x64. I do not take any responsiblity in case it doesn't work as expected and I do not intend to support other platforms as this is only meant for personal use for me specifically, and I do most of my work on Windows still (God help me). I'm open to ideas though, so don't be afraid to give suggestions via pull requests.
