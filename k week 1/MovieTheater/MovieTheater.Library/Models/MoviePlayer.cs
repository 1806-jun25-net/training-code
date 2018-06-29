using MovieTheater.Library.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Library.Models
{
    public class MoviePlayer : IMoviePlayer
    {

        public IMovie Movie { get; set;}

        public delegate void ShowHandler(string title); //Defines a new type ShowHandler, a type of a function that takes no parameters and returns nothing


        public event ShowHandler Show; //triggering the event runs all the functions, the delegates that is subscribed to it.
        //We'll call this event when the movie plays. Any callers can add functions to run whenever that happens by subscribing to the event

        public event Action<string> ShowWithAction;

        //instead of delegates everywhere, can use Func / Action
        //return void -> that's an Action
        //return anything else -> that's a Func

        //Func<string, int>  -- takes a string, returns an int
        //Action<string, int> -- takes a string and an int and returns nothing.

        public void Play(IMovie movie)
        {
            Movie = movie;

            //UNSAFE to call an event like this!
            //Show(movie.Title)

            //Call it with null check:

            //if (Show != null)
            //{
            //  Show(Movie.Title);
            //}

            Show?.Invoke(Movie.Title); //Null-check-related operators ?. ?? 
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
