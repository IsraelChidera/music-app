namespace MusicApp
{
    internal class Songs
    {
        private string? songName;
        public string? SongName { get { return songName; } set { songName = value; } }


    }

    public class SongList
    {

        public void ShuffleList()
        {
            var random = new Random();
        }

        public static void DisplayMusicList()
        {
            List<Songs> songCollection = new List<Songs>()
                    {
                        new Songs() { SongName="my compliments"}
                    };
            songCollection.Add(new Songs() { SongName = "for reals" });
            songCollection.Add(new Songs() { SongName = "Amazed" });
            songCollection.Add(new Songs() { SongName = "Friends" });
            songCollection.Add(new Songs() { SongName = "Grand dad's love" });
            songCollection.Add(new Songs() { SongName = "Go get 'em" });
            //songCollection.Sort();


            var results = songCollection
                      .OrderByDescending(y => y.SongName);

            Console.WriteLine("All songs");
            foreach (var song in songCollection)
            {
                Console.WriteLine($"- \t -- \t{song.SongName}");
            }

            Console.WriteLine("\nMusic section\nWhat do you want to do?");
            Console.WriteLine("\tTo play all songs, press 1\n\tTo add song, press 2\n\tTo exit, press 0\n");
            Console.Write("====>");
            string musicOption = Console.ReadLine();

            bool isTrue = true;
            while (isTrue)
            {


               
                Songs songsList = new();

                switch (musicOption)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Playing all songs");
                        foreach (var song in songCollection)
                        {
                            Console.WriteLine($"Now playing\n- \t-- \t{song.SongName}");
                            Thread.Sleep(2000);
                        }
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Adding songs");
                        Console.WriteLine("\nAdd new song");
                        Console.Write("song ====>");


                        songsList.SongName = Console.ReadLine();
                        songCollection.Add(new Songs() { SongName = songsList.SongName });
                        Console.WriteLine("You've added a song...\n");

                        Console.WriteLine("\nAll songs");
                        foreach (var songs in songCollection)
                        {
                            Console.WriteLine($"\n\t{songs.SongName}");
                        }
                        //isTrue = false;

                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("\nExiting song list");
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPlease provide a valid input\n");
                        Console.ResetColor();                        
                        break;
                }

                Console.WriteLine("\nMusic section\nWhat do you want to do?");
                Console.WriteLine("\tTo play all songs, press 1\n\tTo add song, press 2\n\tTo exit, press 0\n");
                Console.Write("====>");
                musicOption = Console.ReadLine();

            }




        }


    }
}
