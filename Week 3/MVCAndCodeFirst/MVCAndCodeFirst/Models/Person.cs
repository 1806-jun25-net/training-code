using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAndCodeFirst.Models
{
    //this is going to be our context model
    //but we will write it
    //needs to be a POCO -> plain old CLR object
    //needs parameter-less constructor
    //and public get-set properties
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}
