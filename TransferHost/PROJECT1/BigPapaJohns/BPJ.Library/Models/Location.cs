using BPJ.Library.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BPJ.Library
{
    class Location//:ILocation
    {
        //[XmlAttribute]

        //public string Cheese(oz) { get; set; } = "600";
        //public string Pepperoni { get; set; }

       


        //STORE DB'S
        [XmlAttribute]
        //EACH LOCATION WILL START WITH A FULLY-STOCKED INVENTORY
        public Dictionary<string, int> SourceLocationInventoryDict = new Dictionary<string, int>()

        {{ "PepperoniSlices",2000},{ "PizzaSauceOz",400},{"Cheese(oz)",600}
        };

        //SIMPLY EXAMPLE ONLY---POPULATE IN UI OR MAKE TWO LOCATION-SPECIFIC CLASSES
        Dictionary<string, object> StoreLocationContactInfoDC = new Dictionary<string, object>()
        {
            {"Location-Name","D.C."},{"Address","1600 Pennsylvania Avenue NW" },
            { "City","Washington,DC"},{"ZipCode",20500}
        };
        Dictionary<string, object> StoreLocationContactInfoReston = new Dictionary<string, object>()
        {
            {"Location-Name","Restonm"},{"Address","11730 Plaza Americca Dr" },
            { "City","Reston"},{"ZipCode",20500}
        };
        //DB FOR ADDING NEW USERS/INDEXING THEM
        Dictionary<string, object> UserInfoDB = new Dictionary<string, object>()
        {

        };
       //END OF  LOCATION DICTS ///////////////////////
                ////////

        //METHOD HANDLES CHANGES TO EACH LOCATION'S INVENTORY
        public Dictionary<string, int> ManipulateLocationInventory(string item, int amountTaken)
        {
            foreach (var pair in SourceLocationInventoryDict)
            {
                if (item == pair.Key)
                {

                    SourceLocationInventoryDict[pair.Key] -= amountTaken;
                }

            }
            //string obj = "3";
            //object pbj1 = (object)obj;

            return SourceLocationInventoryDict;
        }
        //will hold inventory info and 
        //must decrement after each order



        //DEAL WITH NAMING AND DUPLICATE ISSUES LATER//DONT FORGET

        //METHOD TO ADD NEW INFO TO USERINFODB
        Dictionary<string, object> AddToUserInfoDB(Dictionary<string, object> newUserInfo,int UserID)
        {
            foreach (var pair in newUserInfo)
            {
                UserInfoDB.Add(UserID+pair.Key, pair.Value);
            }
            return UserInfoDB;

        }

       
        
    }
}
