using System;
using System.Collections.Generic;
using System.Text;

namespace XMLSerialization
{
    public class Person
    {
        //xml serialization requires constructor requiring no parameters
        public int Id { get; set; }
        public Name Name { get; set; }
        public List<String> Nicknames { get; set; } = new List<string>();
        public Address Address { get; set; }
        public int Age { get; set; }
    }
}
