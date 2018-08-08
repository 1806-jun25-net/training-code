using System;
using System.Collections.Generic;

namespace Project1.ContextLibrary
{
    public partial class Toppings
    {
        public Toppings()
        {
            PizzaOrderToppings = new HashSet<PizzaOrderToppings>();
        }

        public string ToppingName { get; set; }

        public ICollection<PizzaOrderToppings> PizzaOrderToppings { get; set; }
    }
}
