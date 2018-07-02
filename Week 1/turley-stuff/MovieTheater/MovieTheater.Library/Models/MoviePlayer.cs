using System;
using System.Collections.Generic;
using System.Text;
using MovieTheater.Library.Interfaces;

namespace MovieTheater.Library.Models
{
    public class MoviePlayer : IMoviePlayer
    {
        public IMovie Movie { get; set; }

        public delegate void ShowHandler();

        public event ShowHandler Show;

        //instead of delegates, can use Func/Action
        // void == action, else Func
        //Func<int, string> takes int, returns string
        //Action<int> is a void with int parameter
        //Action<int, int> takes two ints parameters

        public event Action<string> Show2;

        public void Play(IMovie movie)
        {
            Movie = movie;
            Show();
        }

        public void Stop()
        {
        }
    }
}
