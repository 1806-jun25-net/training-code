using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Library.Interface
{
    public interface IMoviePlayer
    {
        void Play(IMovie movie);
        void Stop();
    }
}
