using System;
using System.Collections.Generic;
using System.Text;

namespace Movie.interfaces
{
    interface IMovie
    {
        string title { get; }
        string genre { get;  }
        DateTime relseDate { get; }
    }
}
