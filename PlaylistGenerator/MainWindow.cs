using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using PlaylistGenerator.Properties;

namespace PlaylistGenerator
{
    public partial class MainWindow : Form
    {

        public MainWindow()
        {
            InitializeComponent();
            toolTipBrowser.SetToolTip(folderBrowserButton, "Select MP3-Folder");
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void onFolderBrowseButton(object sender, MouseEventArgs e)
        {
            DialogResult res = folderBrowserDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                MP3Path.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void onExitButton(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void onGeneratePlaylist(object sender, MouseEventArgs e)
        {
            string rootpath=MP3Path.Text;

            if(rootpath.Length==0)
            {
                MessageBox.Show("Select Folder first.","Error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                return;
            }

            string rootname = rootpath.Substring(rootpath.LastIndexOf("\\") + 1);
            List<Playlist> pll = new List<Playlist>();
            GeneratePlaylist(rootpath, rootpath, rootname, ref pll);

            if (PlaylistGenerator.Generate(rootpath, pll, overwritePlayList.Checked))
            {
                MessageBox.Show("Playlists generated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error occured while generating Playlists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void GeneratePlaylist(string rootpath, string path,string dir, ref List<Playlist> playlists)
        {
            string[] files = Directory.GetFiles(@path, "*.mp3");

            if (files.Length > 0)
            {
                Playlist pl;

				if (createOneList.Checked)
				{
					if (playlists.Count > 0)
						pl = playlists[0];
					else
					{
						pl = new Playlist();
						playlists.Add(pl);
					}
				}
				else
				{
					pl = new Playlist();
					playlists.Add(pl);
				}
				string rpath = rootpath;
				if (rpath[rootpath.Length - 1] == '\\')
				{
					rpath = rpath.Substring(0, rpath.Length - 1);
					if (trimFilename.Checked)
					{
						rpath = GetTrimFilename(rpath, false);
					}
				}
				string name = dir.Replace(rpath + "\\", "");
                name = name.Replace("\\", "_");
				if (pl.playlistname == null)
				{
					pl.playlistname = name;
				}
                foreach (string f in files)
                {
					string fn = f;

					if (trimFilename.Checked)
					{
						fn = GetTrimFilename(fn,true);
					}
                    pl.files.Add(fn);
                }
            }

            //SubDirectories durchsuchen
            string[] dirs = Directory.GetDirectories(@path);
            foreach (string directory in dirs)
            {
                string di = directory.Replace(rootpath + "\\", "");
                GeneratePlaylist(rootpath, directory,di, ref playlists);
            }
        }

		private string GetTrimFilename(string filename, bool movefile)
		{
			string f = filename.Substring(filename.LastIndexOf("\\") + 1);
			string path = filename.Substring(0,filename.Length-(filename.Length-filename.LastIndexOf("\\"))+1 );
			string ext = "";
			if (f.LastIndexOf(".") >= 0)
			{
				ext = f.Substring(f.LastIndexOf("."), (filename.Length - filename.LastIndexOf(".")));
				f = f.Substring(0, f.Length - (f.Length - f.LastIndexOf(".")));
			}

			int maxchars = int.Parse(numFileChars.Text);

			string newfile = path + f + ext;
			if (f.Length > maxchars)
			{
				f = f.Substring(0, maxchars);
				newfile = path + f + ext;

				int i = 1;
				while (File.Exists(newfile))
				{
					f = f.Substring(0, f.Length - i.ToString().Length);
					f = f + i.ToString();
					newfile = path + f + ext;
					i++;
				}
			}

			if(movefile && newfile.CompareTo(filename)!=0)
			{
				try
				{
					if (!File.Exists(newfile))
					{
						File.Move(filename, newfile);
					}
					else
						return filename;
				}
				catch(Exception e)
				{
					MessageBox.Show(e.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Stop);
					return filename;
				}
			}

			return newfile;
		}

	}
}