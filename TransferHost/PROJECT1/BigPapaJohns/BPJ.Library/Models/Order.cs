using BPJ.Library.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace BPJ.Library
{
    public class Order
    {
        //RETRIEVEING INFO FROM USER////////
        [DataContract]
        public Dictionary<string,object> NewUserInfo= new Dictionary<string, object>();
        //[XmlAttribute]
        public Dictionary<string,object> NewUserAdd( Dictionary<string,object> info)
            //implements Interface method-1
        {

            //List<User> NewUserInfo = new List<User>();
            foreach(var pair in info)
            {
                NewUserInfo.Add(pair.Key,pair.Value);
            }
            
            return NewUserInfo;
        }
         //////////////////////////////////////////////


        //RETRIEVING Order History FROM LOCATION///////////////////
        public Dictionary<string, object> LocationHist = new Dictionary<string, object>();
        public Dictionary<string, object> LocationHistRetrieval(Dictionary<string,object> locationhistdict )
        {
            foreach(var pair in locationhistdict)
            {
                LocationHist.Add(pair.Key, pair.Value);
            }
            return LocationHist;
        }

        //RETRIEVING Inventory FROM LOCATION///////////////////
        public Dictionary<string, object> LocationInventory = new Dictionary<string, object>();
        public Dictionary<string, object> LocationInventoryRetrieval(Dictionary<string, object> locationinventdict)
        {
            foreach (var pair in locationinventdict)
            {
                LocationInventory.Add(pair.Key, pair.Value);
            }
            return LocationInventory;
        }

        //RETRIEVING CURRENCY/ADDRESS/ETC
        public Dictionary<string, object> LocationGenInfo = new Dictionary<string, object>();
        public Dictionary<string, object> LocationGenInfoRetrieval(Dictionary<string, object> locationgeninfo)
        {
            foreach(var pair in locationgeninfo)
            {
                LocationGenInfo.Add(pair.Key, pair.Value);
            }
            return LocationGenInfo;
        }
        

        ////////////////////////
    


            
    }
}
