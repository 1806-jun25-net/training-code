using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheaterLibrary.Interfaces
{
    interface IMoviePlayer
    {
        void Play(IMovie movie);
        void Stop();
    }
}
