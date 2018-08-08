using System;
using System.Collections.Generic;

namespace Project1.ContextLibrary
{
    public partial class Pizza
    {
        public Pizza()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
        }

        public int PizzaId { get; set; }
        public string PizzaSize { get; set; }
        public string PizzaCrust { get; set; }

        public ICollection<PizzaOrder> PizzaOrder { get; set; }
    }
}
