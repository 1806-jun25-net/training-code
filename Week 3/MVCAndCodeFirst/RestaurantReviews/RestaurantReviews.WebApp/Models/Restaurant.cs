using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.WebApp.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}
