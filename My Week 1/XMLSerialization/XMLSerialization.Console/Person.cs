using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XMLSerialization.Console
{
    [XmlRoot("PersonObject")] // We can change thename that it gives to the person
        // or to any of the elements with this.
    public class Person
    {
        // xmlserializer requires a no-parameter constructor

        [XmlAttribute]
        public int Id { get; set; }
        public Name Name { get; set; }
        public List<string> Nicknames { get; set; } = new List<string>();
        public Address Address { get; set; }
        public int Age { get; set; }
    }
}
