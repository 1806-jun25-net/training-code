using PizzaLibrary.Interface;
using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary.Classes
{
    class Order : IOrder, ILocation, IUser
    {
        public void DisplayLocation()
        {
            throw new NotImplementedException();
        }

        public void DisplayOrder()
        {
            throw new NotImplementedException();
        }

        public void DisplayUser()
        {
            throw new NotImplementedException();
        }
    }
}
