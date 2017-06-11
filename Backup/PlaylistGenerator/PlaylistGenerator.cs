using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PlaylistGenerator.Properties;
using System.IO;
using System.Windows.Forms;
using mp3info;

namespace PlaylistGenerator
{
    class PlaylistGenerator
    {
        public static bool Generate(string rootpath, List<Playlist> playlists, bool overwrite)
        {
            string plname = "";
            foreach (Playlist pl in playlists)
            {
                try
                {
                    if (pl.files.Count > 0)
                    {
                        plname = rootpath + "\\" + pl.playlistname + ".m3u";
                        int i = 1;
                        while (File.Exists(plname) && !overwrite)
                        {
                            plname = rootpath + "\\" + pl.playlistname + "_" + i.ToString("D3") + ".m3u";
                            i++;
                        }

                        using (StreamWriter f = new StreamWriter(plname, false, System.Text.Encoding.Default))
                        {
                            WriteM3UHeader(f);
                            foreach (string entry in pl.files)
                            {
                                WriteExtInf(f, entry, rootpath, pl.playlistname);
                                WriteFileLine(f, entry, rootpath, pl.playlistname);
                            }
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(plname+"\n"+ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                }
            }
            return true;
        }

        private static void WriteM3UHeader(StreamWriter fs)
        {
            fs.WriteLine("#EXTM3U");
        }

        private static void WriteExtInf(StreamWriter fs, string file, string rootpath, string plname)
        {
            string name = createFileTitle(file, rootpath, plname);

            string line = "#EXTINF:-1," + name;

            fs.WriteLine(line);
        }

        private static void WriteFileLine(StreamWriter fs, string file, string rootpath, string plname)
        {
            string name = file;
            name = name.Replace(rootpath + "\\", "");
            fs.WriteLine(name);
        }

        private static string createFileTitle(string file, string rootpath, string plname)
        {
            string title=file.Substring(0,file.Length-4);
            title = title.Replace(rootpath + "\\" + plname + "\\", "");
            title = title.Replace(rootpath + "\\", "");

/*            mp3info.mp3info info = new mp3info.mp3info(file);
            info.ReadAll(file);
            if (info.hasID3v1)
            {
                if (info.id3v1.Title.Length > 0)
                    title = info.id3v1.Title;
            }
            if (info.hasID3v2)
            {
                if (info.id3v2.Title.Length > 0)
                    title = info.id3v2.Title;
                title = title.Replace("\0", "");
                title = title.Replace("ÿþ", "");                
            }*/
            return title;
        }
        
    }
}
