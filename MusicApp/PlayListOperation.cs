using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicApp
{
    internal class PlayListOperation
    {
        //Fields and Properties
        private List<PlayList> _playlist { get; set; } = new List<PlayList>();
        

        //methods
        private void DisplayPlayListData(PlayList playlist)
        {            
            Console.WriteLine($"\n\t{playlist.Name} -- {playlist.Genre}");
        }

        private void DisplayPlayListData(List<PlayList> playlists)
        {
            Console.WriteLine("\n\tPlaylist Name -- Playlist Genre");
            foreach (var playlist in playlists)
            {
                DisplayPlayListData(playlist);
            }
        }

        //constructor
        public void AddPlayList(PlayList playlist)
        {            
            //songCollection.Add(new SongCollection() { SongName = "for reals" });
            _playlist.Add(playlist);
        }

        public void DisplayPlayList(string number)
        {
            var playlist = _playlist.FirstOrDefault(x => x.Genre == number);
            if(playlist == null)
            {
                Console.WriteLine("Playlist not found");
            }
            else
            {
                DisplayPlayListData(playlist);
            }
        }

        public void DisplayAllPlaylist()
        {
            Console.WriteLine("*********************************");
            Console.WriteLine("PLAYLISTS");
            Console.WriteLine("*********************************");
            DisplayPlayListData(_playlist);
        }

        public void DisplayMatchingPlaylist(string searchPhrase)
        {
            var matchingPlaylist = _playlist.Where(c => c.Name.Contains(searchPhrase)).ToList();

            DisplayPlayListData(matchingPlaylist);
        }

        public void RemovePlaylist()
        {
            DisplayAllPlaylist();
            Console.WriteLine("\nEnter playlist name to remove");
            string name = Console.ReadLine();

            foreach(var playList in _playlist)
            {                
                Console.WriteLine("checkin");
                Console.WriteLine(playList.Name);

                if (playList.Name.Equals(name))
                {
                    Console.WriteLine("Succesful");
                }

                Console.WriteLine("Unable to delete playlist");
            }

           
        }

    }
}
