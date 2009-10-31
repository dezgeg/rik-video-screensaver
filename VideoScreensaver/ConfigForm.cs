using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VLCVideoScreensaver
{
	public partial class ConfigForm : Form
	{
		public ConfigForm()
		{
			InitializeComponent();
		}


		private void LocateVLC_button_Click(object sender, EventArgs e)
		{
			this.openFileDialog1.FileName = "vlc.exe";
			this.openFileDialog1.Filter = "VLC Application|vlc.exe";
			if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				if (File.Exists(this.openFileDialog1.FileName))
				{
					this.VLC_Location_box.Text = this.openFileDialog1.FileName;
				}
			}
		}

		private void LocateFiles_button_Click(object sender, EventArgs e)
		{
			if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				if (Directory.Exists(this.folderBrowserDialog1.SelectedPath))
				{
					this.playlistFolder_textbox.Text = this.folderBrowserDialog1.SelectedPath;
				}
			}
		}

	

		private void OkayButton_Click(object sender, EventArgs e)
		{
			bool PlaylistOK = true;
			bool VLCFileOK = true;

			if (!Directory.Exists(this.playlistFolder_textbox.Text))
			{
				PlaylistOK = false;
			}

			if (!File.Exists(this.VLC_Location_box.Text))
			{
				VLCFileOK = false;
			}

			if ((PlaylistOK == false) && (VLCFileOK == false))
			{
				MessageBox.Show("The location of the vlc executable does not exist \nand the playlist folder does not exist");
			}
			else if (PlaylistOK == false)
			{
				MessageBox.Show("The playlist folder is okay");
			}
			else if (VLCFileOK == false)
			{
				MessageBox.Show("The vlc executable does not exist");
			}

			if(VLCFileOK)
			{
				Properties.Settings.Default.VLCLocation = this.VLC_Location_box.Text;	
			}
			if (PlaylistOK)
			{
				Properties.Settings.Default.PlaylistFolder = this.playlistFolder_textbox.Text;
			}

			Properties.Settings.Default.NoAudio = this.DisableAudioCheckbox.Checked;
			Properties.Settings.Default.RandomPlay = this.RandomPlayCheckbox.Checked;

			Properties.Settings.Default.Save();

			this.Close();
		}

		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnLoad(object sender, EventArgs e)
		{
			this.VLC_Location_box.Text = Properties.Settings.Default.VLCLocation;
			this.playlistFolder_textbox.Text = Properties.Settings.Default.PlaylistFolder;
			this.RandomPlayCheckbox.Checked = Properties.Settings.Default.RandomPlay;
			this.DisableAudioCheckbox.Checked = Properties.Settings.Default.NoAudio;
		}
	}
}
