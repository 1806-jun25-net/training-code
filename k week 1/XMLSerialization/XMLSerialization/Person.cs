using System;
using System.Collections.Generic;
using System.Text;

namespace XMLSerialization
{
    public class Person
    {
        //xml serilizer requires no-parameter constructor
        public int Id { get; set; }
        public Name Name { get; set; }
        public ICollection<string> Nicknames { get; set; } = new List<string>();
        public Address Address { get; set; }
        public int Age { get; set; }
    }
}
