using System;
using System.Collections.Generic;

namespace Project1.ContextLibrary
{
    public partial class LocationInventory
    {
        public LocationInventory()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
        }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public double? Dough { get; set; }
        public int? Pepperoni { get; set; }
        public int? Sausage { get; set; }
        public int? Bacon { get; set; }
        public int? Mushrooms { get; set; }
        public int? Olives { get; set; }
        public int? Anchovies { get; set; }
        public int? Salami { get; set; }
        public int? Chicken { get; set; }
        public int? Onions { get; set; }
        public int? Peppers { get; set; }

        public ICollection<PizzaOrder> PizzaOrder { get; set; }
    }
}
