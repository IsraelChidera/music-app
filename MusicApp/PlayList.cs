using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class PlayList
    {
        public PlayList(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }

        public string Name { get; set; }
        public string Genre { get; set; }
    }
}
