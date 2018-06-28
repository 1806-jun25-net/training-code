using System;
using System.Collections.Generic;
using System.Text;

namespace XMLSerialization.Console
{
    class Person
    {
        // xmlserializer require no-parameter constructor


        public int Id { get; set; }
        public Name Name { get; set; }
        public List<string> Nicknames { get; set; } = new List<string>();
        public Address Address { get; set; }
        public int Age { get; set; }
    }
}
