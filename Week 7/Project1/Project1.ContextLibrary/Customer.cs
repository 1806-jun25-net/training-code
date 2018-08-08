using System;
using System.Collections.Generic;

namespace Project1.ContextLibrary
{
    public partial class Customer
    {
        public Customer()
        {
            PizzaOrder = new HashSet<PizzaOrder>();
        }

        public int CustomerId { get; set; }
        public string CustomerName { get; set; }

        public ICollection<PizzaOrder> PizzaOrder { get; set; }
    }
}
