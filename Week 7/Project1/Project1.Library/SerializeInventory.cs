using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Project1.Library
{
    public class SerializeInventory
    {
        [XmlAttribute]
        public string Location { get; set; }
        public double Dough { get; set; }
        public List<string> ToppingLevels { get; set; } = new List<string>();
    }
}