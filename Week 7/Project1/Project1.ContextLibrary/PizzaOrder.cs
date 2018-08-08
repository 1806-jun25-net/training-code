using System;
using System.Collections.Generic;

namespace Project1.ContextLibrary
{
    public partial class PizzaOrder
    {
        public PizzaOrder()
        {
            PizzaOrderToppings = new HashSet<PizzaOrderToppings>();
        }

        public int PizzaOrderId { get; set; }
        public int CustomerId { get; set; }
        public int LocationId { get; set; }
        public int PizzaId { get; set; }
        public int? PizzaQuantity { get; set; }
        public double? OrderCost { get; set; }
        public DateTime? OrderTime { get; set; }

        public Customer Customer { get; set; }
        public LocationInventory Location { get; set; }
        public Pizza Pizza { get; set; }
        public IEnumerable<PizzaOrderToppings> PizzaOrderToppings { get; set; }
    }
}
