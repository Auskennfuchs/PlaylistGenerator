using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PlaylistGenerator
{
    class MusicID3Tag
    {

        public byte[] TAGID = new byte[3];      //  3
        public byte[] Title = new byte[30];     //  30
        public byte[] Artist = new byte[30];    //  30 
        public byte[] Album = new byte[30];     //  30 
        public byte[] Year = new byte[4];       //  4 
        public byte[] Comment = new byte[30];   //  30 
        public byte[] Genre = new byte[1];      //  1

    }

    class MP3ID3Tag
    {

        private string title, artist, album, year, comment, genre;

        public string Title
        {
            get
            {
                return title;
            }
        }

        public string Artist
        {
            get
            {
                return artist;
            }
        }

        public bool ReadTag(string file)
        {
            using (FileStream fs = File.OpenRead(file))
            {
                if (fs.Length >= 128)
                {
                    MusicID3Tag tag = new MusicID3Tag();
                    fs.Seek(-128, SeekOrigin.End);
                    fs.Read(tag.TAGID, 0, tag.TAGID.Length);
                    fs.Read(tag.Title, 0, tag.Title.Length);
                    fs.Read(tag.Artist, 0, tag.Artist.Length);
                    fs.Read(tag.Album, 0, tag.Album.Length);
                    fs.Read(tag.Year, 0, tag.Year.Length);
                    fs.Read(tag.Comment, 0, tag.Comment.Length);
                    fs.Read(tag.Genre, 0, tag.Genre.Length);
                    string theTAGID = Encoding.Default.GetString(tag.TAGID);

                    if (theTAGID.Equals("TAG"))
                    {
                        title = Encoding.Default.GetString(tag.Title);
                        artist = Encoding.Default.GetString(tag.Artist);
                        album = Encoding.Default.GetString(tag.Album);
                        year = Encoding.Default.GetString(tag.Year);
                        comment = Encoding.Default.GetString(tag.Comment);
                        genre = Encoding.Default.GetString(tag.Genre);
                    }
                }
            }
            return true; 
        }
    }
}
