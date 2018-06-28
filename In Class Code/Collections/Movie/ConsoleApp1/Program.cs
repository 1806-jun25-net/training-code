using Movie.Movies;
using System;
using System.Reflection.Metadata;

namespace MovieTheater.UI

{
    class Program
    {
        static void Main(string[] args)
        {
            
            DVDMovie lostArc = new DVDMovie
            {
                title = "hello",
                genre = "hi",
               
            };

            var player = new MusicPlayer();

            MusicPlayer.ShowHandler handler = PrintMessage;

            player.Show += handler;

            player.Show =+ handler;
        }
        MusicPlayer.ShowHandler handler2 = (string e) => Console.WriteLine(e);


        handler2("Ruing hadler2");

        Action <string> handler3 = (string e) => Console.WriteLine(e);

        player.Play(lostArc);

        }

}
