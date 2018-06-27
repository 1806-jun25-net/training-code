using System;
using System.Collections.Generic;
using System.Text;

namespace Animas.Library
{
    public interface IAnimal
    {
        string Name { get; set; }
        void MakeSound();
        void goToLocation();
        string OwnerName { get; set; }
    }
}
