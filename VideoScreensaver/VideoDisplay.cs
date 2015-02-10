/*
    rik-video-screensaver
    Copyright (C) 2009  R.I.Kelsey

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MouseKeyboardActivityMonitor;
using MouseKeyboardActivityMonitor.WinApi;

namespace VLCVideoScreensaver
{
	public partial class VideoDisplay : Form
	{
        KeyboardHookListener keyboardHook;
        MouseHookListener mouseHook;
		Point InitialMouse;
		int ScreenNumber;

		bool thisIsPrimary;
		
		System.Diagnostics.Process theProcess;

		public VideoDisplay()
		{
			InitializeComponent();
			this.ScreenNumber = 0;
		}

		public VideoDisplay( int ScreenNum )
		{
			InitializeComponent();
			this.ScreenNumber = ScreenNum;
		}

		private void onLoad(object sender, EventArgs e)
		{

			Cursor.Hide();
			this.thisIsPrimary = Screen.AllScreens[this.ScreenNumber].Primary;

			if (this.thisIsPrimary == false)
			{
				/* Not the primary monitor */
				this.BackColor = Color.Black;
				this.Bounds = Screen.AllScreens[this.ScreenNumber].Bounds;
			}
			else
			{
				String ArgumentList = " \"" + Properties.Settings.Default.PlaylistFolder + "\" ";
				ArgumentList += " --no-qt-system-tray --qt-notification=0 --video-on-top -f -L ";
				if (Properties.Settings.Default.NoAudio)
				{
					ArgumentList += " --no-audio";
				}
				if (Properties.Settings.Default.RandomPlay)
				{
					ArgumentList += " -Z";
				}
				this.theProcess = new System.Diagnostics.Process();
				this.theProcess.StartInfo.FileName = "vlc.exe";
				this.theProcess.StartInfo.Arguments = ArgumentList;
				this.theProcess.StartInfo.WorkingDirectory = Path.GetDirectoryName(Properties.Settings.Default.VLCLocation);

				this.theProcess.Start();

                // System.Threading.Thread.Sleep(1000);
                GlobalHooker gh = new GlobalHooker();
                this.keyboardHook = new KeyboardHookListener(gh);
                this.keyboardHook.Enabled = true;
                this.keyboardHook.KeyDown += OnKeypress;

                this.mouseHook = new MouseHookListener(gh);
                this.mouseHook.Enabled = true;
                this.mouseHook.MouseDown += OnMouseClick;
                this.mouseHook.MouseMove += OnMouseMove;
            }
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
		{
			if (!InitialMouse.IsEmpty)
			{
				if (Math.Abs(InitialMouse.X - e.X) > 20 || Math.Abs(InitialMouse.Y - e.Y) > 20)
                {
					this.KillVLC();
				}
			}
			else
			{
				InitialMouse = new Point(e.X, e.Y);
			}
		}

		private void OnKeypress(object sender, KeyEventArgs e)
		{
			this.KillVLC();
		}

		private void OnMouseClick(object sender, MouseEventArgs e)
		{
			this.KillVLC();
		}

		private void KillVLC()
		{
            if (this.theProcess.HasExited == false)
			{
				this.theProcess.CloseMainWindow();
				this.theProcess.Kill();
			}
            this.Close();
        }

    }
}
