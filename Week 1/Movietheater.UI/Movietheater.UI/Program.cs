using System;
using MovieTheaterLibrary;

namespace Movietheater.UI
{
    class Program

    {

        static void PrintMessage()
        {
            Console.WriteLine($"Showing movie)
        }


        static void Main(string[] args)
        {
            DVDMovies lostArk = new DVDMovies()
            {
                lostArk.Title = "Raiders of the Lost Ark";
            lostArk.Genre = " Action/Adventure";
            lostArk.ReleaseDate = new DateTime(1980, 1, 1)
                };



    }

    var player = new MoviePlayer();

    MoviePlayer.Showhandler handler = PrintMessage;

    //subscribe to an event

    player.Show += handler; 

}
    }

