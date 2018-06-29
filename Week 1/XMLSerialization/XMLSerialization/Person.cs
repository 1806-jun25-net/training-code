using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XMLSerialization
{
    public class Person
    {
        // xmlserializer requires no-parameter constructor

        [XmlAttribute]
        public int Id { get; set; }
        public Name Name { get; set; }
        public List<string> Nicknames { get; set; } = new List<string>();
        public Address Address { get; set; }
        public int Age { get; set; }
    }
}
