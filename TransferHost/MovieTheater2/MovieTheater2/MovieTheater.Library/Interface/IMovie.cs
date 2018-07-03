using System;
using System.Collections.Generic;
using System.Text;

namespace MovieTheater.Library.Interface
{
    public interface IMovie
    {
        string Title { get; }
        string Genre { get; }
        DateTime ReleaseDate { get; }
    }
}
