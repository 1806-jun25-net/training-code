using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheaterLibrary.Interface
{
    public interface IMoviePlayer
    {
        void Play(IMovies Movie);
        void Stop();

        event Show();


    }
}
