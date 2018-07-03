using System;
using System.Collections.Generic;
using System.Text;

namespace BPJ.Library
{
    public interface IUser
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        //string Location { get; set; }//in model(class):"=<default location>"
        //maybe location is handled by order/Location interfaces
        long UserID { get; set; }
        long PhoneNumber { get; set; }
        string Email { get; set; }
        long CreditCardNum { get; set; }
        int OrderCount { get; set; }



        

    }
}
