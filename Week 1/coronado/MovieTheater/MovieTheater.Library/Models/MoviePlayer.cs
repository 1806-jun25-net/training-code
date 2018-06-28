using MovieTheater.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Library.Models
{
    public class MoviePlayer : IMoviePlayer
    {
        public IMovie Movie { get; set; }

        public delegate void ShowHandler(string title); // a delegate is a reference to a method with a specific set of parameters and a return type.

      

        // We'll call this event when the movie plays.
        // Any subscribers can add functions to run whenever that happens
        // by subscribing to the event
        public event ShowHandler Show; // triggering an event runs all the delegates/subscribed functions of the event

        // instead of delegates everywhere, can use Func / Action
        // return void -> that's an Action
        // return anything else -> that's a Func

        //Func<int,  string>    -- takes a string, returns an int
        //Action<sttring, int>  -- takees a string and int, returns nothing

        public event Action<string> ShowWithAction;

        public void Play(IMovie movie)
        {
            Movie = movie;

            // UNSAFE to call an event like this!
            //Show(movie.Title);

            /*
            // long version; calling with null check
            if (Show != null)
            {
                Show(movie.Title);
            }
            */

            // short version; null-check-related operators ?. and ??
            Show?.Invoke(movie.Title);

        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
