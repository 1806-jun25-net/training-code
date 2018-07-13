using System;
using System.Collections.Generic;

namespace RestaurantReviews.Context.Models
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            Review = new HashSet<Review>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Review> Review { get; set; }
    }
}
