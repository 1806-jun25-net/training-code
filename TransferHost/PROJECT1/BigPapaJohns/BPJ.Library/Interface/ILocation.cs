using System;
using System.Collections.Generic;
using System.Text;

namespace BPJ.Library.Interface
{
    public interface ILocation
    {
        Dictionary<string, int> RetrievePizzaInventoryDict();//property
                                                            //above is for: Dictionary<string, int> PizzaIngredients;
                                                            //in 'Location' models        

        void StockCheckEnforcer();//decrementing pizza ingredients
        //rejects orders that cannot be fulfilled with remaning

        Dictionary<string, object> AddToUserInfoDB(); //for database of indexable users
        //Will supply User History
        //will take from UserNewOrderDetails+ IUser
        //List<IOrder>UserInfoDB{get;set;}; might have to use this instead to take new info from IOrder

        Dictionary<string, object> GrabLocationOrdersHistoryDB();//update by User NEw Details 
        //as well?It'll take Something from IOrder
        //will grab required info from other DBs, do not grab entire DBs

        Dictionary<string, int> CashRegister{get;set;}//simple property to get set transactions

        Dictionary<string, int> ManipulateLocationInventory();//will hold inventory info and 
        //must decrement after each order

        

    }
}
