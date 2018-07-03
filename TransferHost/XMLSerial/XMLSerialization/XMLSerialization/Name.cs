using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XMLSerialization
{
    public class Name
    {
        //[XmlAttribute]
        public string First { get; set; }
        public string Last { get; set; }
    }
}
