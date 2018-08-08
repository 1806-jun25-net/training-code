using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.MVC.Models
{
    public class Customer
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
