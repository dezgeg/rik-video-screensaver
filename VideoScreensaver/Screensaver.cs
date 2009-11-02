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
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace VLCVideoScreensaver
{
	class ClockDisplayParams : Object
	{
		public int ScreenNumber;
		public ClockDisplayParams(int i) { this.ScreenNumber = i; }
	}

	static class Screensaver
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			if (args.Length > 0)
			{
				if (args[0].ToLower().Trim().Substring(0, 2) == "/c") // load the config stuff
				{
					ShowTheConfig();
				}
				else if (args[0].ToLower() == "/s") // load the screensaver
				{
					RunTheScreensaver();
				}
				else if (args[0].ToLower() == "/p") // load the preview
				{
					ShowThePreview();
				}
			}
			else // No arguments. Just run the screen saver
			{
				RunTheScreensaver();
			}
		}

		static void RunTheScreensaver()
		{
			bool KeepRunning = false;
			const int MaxThreads_Screens = 5;
			Thread[] ArrayofThreads = new Thread[MaxThreads_Screens];

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			int screens = Screen.AllScreens.GetUpperBound(0);
			for (int i = 0; (i <= screens) && (i < MaxThreads_Screens); i++)
			{
				ClockDisplayParams dp = new ClockDisplayParams(i);

				ArrayofThreads[i] = new Thread( new ParameterizedThreadStart(CreateEachScreen) );
				ArrayofThreads[i].IsBackground = true;
				ArrayofThreads[i].Start(dp);
				KeepRunning = true;
			}

			while (KeepRunning)
			{
				Thread.Sleep(1000);

				for (int i = 0; (i <= Screen.AllScreens.GetUpperBound(0)) && (i < 5); i++)
				{
					if (!ArrayofThreads[i].IsAlive)
					{
						KeepRunning = false;
					}
				}
			}

			return;
		}

		static void CreateEachScreen( object data )
		{
			if (data is ClockDisplayParams)
			{
				try
				{
					Application.Run(new VideoDisplay(((ClockDisplayParams)data).ScreenNumber));
				}
				catch (System.Exception e)
				{
					MessageBox.Show("ScreenSaver:" + e.Message + " Src:" + e.Source.ToString());
				}
			}
		}

		static void ShowThePreview ( )
		{
		}

		static void ShowTheConfig ( )
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new ConfigForm());
		}
	}
}
