using MovieTheater.Library.Models;
using System;
using System.Collections.Generic;

namespace MovieTheater.IUI
{
    class Program
    {
        static void PrintMessage(string title)
        {
            Console.WriteLine($"Showing Movie: {title}!");
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

            //subscribe to an event
            player.Show += handler;

            //unsubscribe to an event
            player.Show -= handler;

            player.Show += handler;

            MoviePlayer.ShowHandler handler2 = (string s) => Console.WriteLine(s); //Lambda expression
            //void handler2(string s) => Console.WriteLine(s); //Local function declaration
            handler2("running handler2");

            Action<string> handler3 = (string s) => Console.WriteLine(s);

            var actionDict = new Dictionary<string, Action<string>>();

            player.Show += (string s) => Console.WriteLine("Handle with Lambda");

            player.Show += (string s) =>
            {
                if (s.Length > 1)
                {
                    Console.WriteLine("long title");
                }
            };
            //Multiple line lambda function

            player.Play(lostArk);
        }
    }
}
