using System;
using System.Collections.Generic;
using System.Text;
using MovieTheaterLibrary.Interface.IMoviePlayer;

namespace MovieTheaterLibrary.Models
{
    public class MoviePlayer : IMoviePlayer
    {
        public IMovies Movie { get; set; }

        public delegate void Showhandler(); // defines a new type "showhandler" and is going to be the type of function
        // that takes no parameters and returns nothing. 


            // we will call this event when the movie plays. 
// any callers can add functions to r un whenever that happens by subscribing to the event
        public event Showhandler Show;


      


        public void Play(IMovies movie)
        {
            Movie = movie;
            Show();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        
        }
    }
}
