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

namespace VLCVideoScreensaver
{
	partial class ConfigForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.label1 = new System.Windows.Forms.Label();
            this.LocateVLC_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.VLC_Location_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playlistFolder_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LocalFiles_button = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OkayButton = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.DisableAudioCheckbox = new System.Windows.Forms.CheckBox();
            this.RandomPlayCheckbox = new System.Windows.Forms.CheckBox();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "VLC Video screensaver by Richard Kelsey";
            // 
            // LocateVLC_button
            // 
            this.LocateVLC_button.Location = new System.Drawing.Point(516, 100);
            this.LocateVLC_button.Name = "LocateVLC_button";
            this.LocateVLC_button.Size = new System.Drawing.Size(75, 23);
            this.LocateVLC_button.TabIndex = 1;
            this.LocateVLC_button.Text = "Locate...";
            this.LocateVLC_button.UseVisualStyleBackColor = true;
            this.LocateVLC_button.Click += new System.EventHandler(this.LocateVLC_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // VLC_Location_box
            // 
            this.VLC_Location_box.Location = new System.Drawing.Point(50, 102);
            this.VLC_Location_box.Name = "VLC_Location_box";
            this.VLC_Location_box.Size = new System.Drawing.Size(460, 20);
            this.VLC_Location_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Location of VLC";
            // 
            // playlistFolder_textbox
            // 
            this.playlistFolder_textbox.Location = new System.Drawing.Point(50, 172);
            this.playlistFolder_textbox.Name = "playlistFolder_textbox";
            this.playlistFolder_textbox.Size = new System.Drawing.Size(460, 20);
            this.playlistFolder_textbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Playlist file to play";
            // 
            // LocalFiles_button
            // 
            this.LocalFiles_button.Location = new System.Drawing.Point(516, 170);
            this.LocalFiles_button.Name = "LocalFiles_button";
            this.LocalFiles_button.Size = new System.Drawing.Size(75, 23);
            this.LocalFiles_button.TabIndex = 6;
            this.LocalFiles_button.Text = "Locate";
            this.LocalFiles_button.UseVisualStyleBackColor = true;
            this.LocalFiles_button.Click += new System.EventHandler(this.LocateFiles_button_Click);
            // 
            // OkayButton
            // 
            this.OkayButton.Location = new System.Drawing.Point(435, 224);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(75, 23);
            this.OkayButton.TabIndex = 7;
            this.OkayButton.Text = "Okay";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Location = new System.Drawing.Point(516, 224);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 8;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // DisableAudioCheckbox
            // 
            this.DisableAudioCheckbox.AutoSize = true;
            this.DisableAudioCheckbox.Location = new System.Drawing.Point(108, 228);
            this.DisableAudioCheckbox.Name = "DisableAudioCheckbox";
            this.DisableAudioCheckbox.Size = new System.Drawing.Size(90, 17);
            this.DisableAudioCheckbox.TabIndex = 9;
            this.DisableAudioCheckbox.Text = "Disable audio";
            this.DisableAudioCheckbox.UseVisualStyleBackColor = true;
            // 
            // RandomPlayCheckbox
            // 
            this.RandomPlayCheckbox.AutoSize = true;
            this.RandomPlayCheckbox.Location = new System.Drawing.Point(243, 228);
            this.RandomPlayCheckbox.Name = "RandomPlayCheckbox";
            this.RandomPlayCheckbox.Size = new System.Drawing.Size(89, 17);
            this.RandomPlayCheckbox.TabIndex = 10;
            this.RandomPlayCheckbox.Text = "Random Play";
            this.RandomPlayCheckbox.UseVisualStyleBackColor = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // ConfigForm
            // 
            this.AccessibleDescription = "Screensaver configuration box";
            this.AccessibleName = "Screensaver configuration box";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 307);
            this.Controls.Add(this.RandomPlayCheckbox);
            this.Controls.Add(this.DisableAudioCheckbox);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.LocalFiles_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.playlistFolder_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VLC_Location_box);
            this.Controls.Add(this.LocateVLC_button);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConfigForm";
            this.Text = "Screensaver configuration V0.1";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button LocateVLC_button;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TextBox VLC_Location_box;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox playlistFolder_textbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button LocalFiles_button;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button OkayButton;
		private System.Windows.Forms.Button Cancel_Button;
		private System.Windows.Forms.CheckBox DisableAudioCheckbox;
		private System.Windows.Forms.CheckBox RandomPlayCheckbox;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}