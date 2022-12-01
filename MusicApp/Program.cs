namespace MusicApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Music lovers!");


            Console.WriteLine("\nWhat do you want to do?");
            Console.WriteLine("1: Add Playlist");
            Console.WriteLine("2: Display Playlist By Number");
            Console.WriteLine("3: Display All Playlist");
            Console.WriteLine("4: Search for playlist");
            Console.WriteLine("0: To exit the application");
            string userInput = Console.ReadLine();
            PlayListOperation playlist = new PlayListOperation();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Input a name for your playlist");
                        Console.Write(" ==> ");
                        string? name = Console.ReadLine();
                        Console.WriteLine("Input a number for your playlist");
                        Console.Write(" ==> ");
                        string? number = Console.ReadLine();

                        var newPlaylist = new PlayList(name, number);
                        playlist.AddPlayList(newPlaylist);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Input playlist number to search");
                        Console.Write("==>");
                        var search = Console.ReadLine();
                        playlist.DisplayPlayList(search);
                        break;
                    case "3":
                        Console.Clear();
                        playlist.DisplayAllPlaylist();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Name search phrase");
                        var searchphrase = Console.ReadLine();
                        playlist.DisplayMatchingPlaylist(searchphrase);
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("\nOuch! We will love to see you again");
                        return;
                    default:
                        Console.WriteLine("Invalid input... Try a valid option");
                        break;
                }

                Console.WriteLine("\n\nSelect operation");
                Console.WriteLine("\t1: Add Playlist");
                Console.WriteLine("\t2: Display Playlist By Number");
                Console.WriteLine("\t3: Display All Playlist");
                Console.WriteLine("\t4: Search for playlist");
                Console.WriteLine("\t0: To exit the application");
                userInput = Console.ReadLine();

            }
        }
    }
}