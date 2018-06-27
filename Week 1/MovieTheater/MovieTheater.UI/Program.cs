using MovieTheater.Library.Models;
using System;
using System.Collections.Generic;

namespace MovieTheater.UI
{
    class Program
    {
        static void PrintMessage(string title)
        {
            Console.WriteLine($"Showing movie {title}!");
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

            // subscribe to an event.
            player.Show += handler;

            // unsubscribe from an event.
            //player.Show -= handler;
            // now NO delegate is subscribed to the event!

            //player.Show += handler;

            MoviePlayer.ShowHandler handler2 = (string s) => Console.WriteLine(s);
            //void handler2(string s) => Console.WriteLine(s);

            handler2("Running handler2");

            Action<string> handler3 = (string s) => Console.WriteLine(s);

            var actionDict = new Dictionary<string, Action<string>>();

            player.Show += (string s) => Console.WriteLine("Handle with lambda");

            player.Show += (string s) =>
            {
                if (s.Length > 10)
                {
                    Console.WriteLine("long title");
                }
            };

            player.Play(lostArk);
        }
    }
}
