using Movie.interfaces;
using System;

using System.Collections.Generic;
using System.Text;

namespace Movie.Movies
{
    public class MusicPlayer : IMoviePlayer

    {
        
        

        public delegate void ShowHandler(string title);
        public event ShowHandler Show;
        public IMovie movie { get; set; }
        public event Action<string> ShowAction;

        public void play(IMovie movie)
        {
            //if (Show(movie.title) != null )
            //{
            //    Show(movie.title);
            //}
            movie = this.movie; 
        }

        public void stop()
        {
            throw new NotImplementedException();
        }
          


    }
}
