using MovieTheaterLibrary.Models;
using NLog;
using System;
using System.Collections.Generic;

namespace MovieTheatre.UI
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void PrintMessage(string title)
        {
            Console.WriteLine($"Showing Movie: {title}");
        }
        static void Main(string[] args)
        {
            logger.Info("Application Start");
            try
            {
                throw new ArgumentException("error");
            }
            catch (ArgumentException ex)
            {
                logger.Error(ex, "error thrown right after startup");
            }

            logger.Info("Application shutting down");

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
            //player.Show -= handler;

            MoviePlayer.ShowHandler handler2 = (string s) => Console.WriteLine(s); //lambda expression
            //void handler2(string s) => Console.WriteLine(s); //local function expression
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
