using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XMLSerialization
{
    [XmlRoot(ElementName = "PersonObject")]
    public class Person
    {
        //XMLSerializer requires no-parameter constructor

        [XmlAttribute]
        public int ID { get; set; }
        public Name Name { get; set; }
        public List<string> Nicknames { get; set; } = new List<string>();
        public Address Address { get; set; }
        public int Age { get; set; }
    }
}
