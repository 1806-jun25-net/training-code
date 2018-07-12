using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMVC.Models
{
    // this is going to be our context model.
    // but we will write it.
    // should be a "POCO" "plain old CLR object"
    // need parameter-less contructor (usually default)
    // and public get-set properties
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
    }
}
