using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.interfaces
{
    interface IMoviePlayer
    {
        void play(IMovie movie);
        void stop();
        
      
    }
}
