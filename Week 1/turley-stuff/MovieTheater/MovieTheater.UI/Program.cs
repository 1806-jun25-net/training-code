using System;
using MovieTheater.Library.Models;

namespace MovieTheater.UI
{
    class Program
    {


        static void PrintMessage()
        {
            Console.WriteLine("Showing movie!");
        }

        static void PrintStuff()
        {
            Console.WriteLine("Stuff...");
        }

        static void Main(string[] args)
        {
            DVDMovie lostArk = new DVDMovie
            {
                Title = "Raiders of the Lost Ark",
                Genre = "Action/Adventure",
                ReleaseDate = new DateTime(1980, 1, 1)
            };

            var player = new MoviePlayer();

            MoviePlayer.ShowHandler handler = PrintMessage;
            MoviePlayer.ShowHandler handler2 = () => Console.WriteLine("I didnt change it");

            Action<string> handler3 = (string s) =>
            {
                int x = 7 * 74;
                Console.WriteLine(s + x);
            };


            player.Show += handler;
            player.Show += PrintStuff;
            player.Show += PrintMessage;

            player.Play(lostArk);
            Console.ReadLine();
            Console.Clear();
            player.Show -= handler;
            player.Play(lostArk);
            Console.ReadLine();
        }
    }
}
