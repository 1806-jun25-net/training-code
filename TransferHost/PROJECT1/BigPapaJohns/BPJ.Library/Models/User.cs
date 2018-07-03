using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BPJ.Library.Models
{
   public class User : IUser
    {
        //public static string fname="hi";
        //public static string lname;
        //public static long userId;
        //public static long phoneNumber;
        //public static string email;
        //public static long creditCardNumber;
        //public static int TotalCustOrders;

        [XmlAttribute]
        public string FirstName { get;
            set; }
       public string LastName{get; set;} 
        //string Location { get; set; }//in model(class):"=<default location>"
        //maybe location is handled by order/Location interfaces
        public long UserID{get;
            set ;} 
        public long PhoneNumber{ get ;
            set ;} 
        public string Email{get ;
            set;}
        public long CreditCardNum{get ;
            set ;} 
        public int OrderCount{get ;
            set;}

        //trt to create list of userInfo on orders
        //[XmlAttribute]
        //public static Dictionary<string, object> UserInfo = new Dictionary<string, object>()
        //{
        //    //remember to downcast these objects to their respective value-types
        //    {"First Name",fname},
        //    { "Last Name",lname },
        //    {"User ID",userId },
        //    {"Phone Number", phoneNumber},
        //    {"Email",email},
        //    {"CreditCard#",creditCardNumber },
        //    {"Total Orders",TotalCustOrders },



        //};
        
       
        
    }
}
