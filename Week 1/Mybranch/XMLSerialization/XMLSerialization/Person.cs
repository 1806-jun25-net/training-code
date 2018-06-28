using System;
using System.Collections.Generic;
using System.Text;

namespace XMLSerialization
{
    public class Person
    {

        //XML Serializer requires no parameter constructor

        public int ID { get; set; }
        public Name Name { get; set; }
        public List<string> Nickname { get; set; } = new List<string>();
        public Address Address { get; set; }
        public int Age { get; set; }
    }
}
