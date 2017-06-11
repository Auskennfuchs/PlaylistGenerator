using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlaylistGenerator.Properties
{
    class Playlist
    {
        private string m_plname;
        public List<string> files;

        public string playlistname
        {
            get
            {
                return m_plname;
            }

            set
            {
                m_plname = value;
            }
        }

        public Playlist()
        {
            files=new List<string>();
            files.Clear();
        }
    }
}
