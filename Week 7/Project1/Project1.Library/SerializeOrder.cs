using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Project1.Library
{
    public class SerializeOrder
    {
        [XmlAttribute]
        public string CustName { get; set; }
        public string OrderLocation { get; set; }
        public string OrderSize { get; set; }
        public string OrderCrust { get; set; }
        public List<string> OrderToppings { get; set; } = new List<string>();
        public int OrderQuantity { get; set; }
        public double OrderCost { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
