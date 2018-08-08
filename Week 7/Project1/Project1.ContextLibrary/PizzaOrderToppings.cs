using System;
using System.Collections.Generic;

namespace Project1.ContextLibrary
{
    public partial class PizzaOrderToppings
    {
        public int PizzaOrderId { get; set; }
        public string ToppingName { get; set; }

        public PizzaOrder PizzaOrder { get; set; }
        public Toppings ToppingNameNavigation { get; set; }
    }
}
