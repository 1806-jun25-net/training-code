using MovieTheaterLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheaterLibrary.Models
{
    public class MoviePlayer : IMoviePlayer
    {
        private IMovie _movie;

        public IMovie Movie
        {
            get => _movie;
            set
            {
                _movie = value;
            }
        }

        //reference to a method with a particular set of parameters and return type
        public delegate void ShowHandler(string title);

        //something that can hold a set of event handlers that are subscribed to the event
        //and then the event can be triggered calling all the subscribed events
        //we'll call this event when the movie plays
        //any subscribers can add functions to run whenever that happens by subscribing to that event
        public event ShowHandler Show;


        //instead of delegates, can use Func / Action
        //return void -> Action
        //return anything else -> Func

        //Func<string, int>   -- takes a string and return an int
        //Action<string, int> -- takes a string & an int, returns nothing
        public event Action<string> ShowWithAction;

        public void Play(IMovie movie)
        {
            Movie = movie;

            //unsafe to call events like this
            //Show(movie.Title);


            Show?.Invoke(Movie.Title);
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
