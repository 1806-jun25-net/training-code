using PizzaLibrary.Interface;
using PizzaLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaLibrary.Classes
{
    class User : IUser, ILocation, IOrder
    {

        //user's complete name
        public string UserFullName { get; set; }
        //user's order location with default order location as 'Reston, VA'
        public string UserLocation { get; set; } = "Reston, VA";


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