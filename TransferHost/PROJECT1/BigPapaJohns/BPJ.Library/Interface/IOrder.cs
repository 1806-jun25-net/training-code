using System;
using System.Collections.Generic;
using System.Text;

namespace BPJ.Library.Interface
{
    public interface IOrder
    {
        string DefaultLocation { get; set; }
        
        //DICTIONARIES
        Dictionary<string,object> NewUserAdd();//implemented
        Dictionary<string, object> LocationHistRetrieval();//implemented
        Dictionary<string, object> LocationInventoryRetrieval();
        Dictionary<string, object> LocationGenInfoRetrieval();
        Dictionary<string,int> UserNewOrderDetails { get; set; }//will be sent 
        //out to location for it to handle transaction
        //<><><
        //also used by UI to display order details

        DateTime OrderTime { get; set; }

        List<ILocation> OrderSuggestionDB { get; set; }//will receive  
        //user's order history + Info and make suggestion from that info
        //OR CAN you index locations db's and make suggestion from there?

        string location { get; set; }//need info from locations(?)
        //remember to give default location in model order
        int PizzaCount { get; set; }
        int TotalValue(ILocation locationPrices);

    }
}
