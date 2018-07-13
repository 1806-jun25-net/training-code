using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantReviews.Library.Models
{
    public static class Mapper
    {
        public static Restaurant Map(Context.Models.Restaurant restaurant) => new Restaurant
        {
            Id = restaurant.Id,
            Name = restaurant.Name,
            Reviews = Map(restaurant.Review).ToList()
        };

        public static Context.Models.Restaurant Map(Restaurant restaurant) => new Context.Models.Restaurant
        {
            Id = restaurant.Id,
            Name = restaurant.Name,
            Review = Map(restaurant.Reviews).ToList()
        };
        
        public static Review Map(Context.Models.Review review) => new Review
        {
            Id = review.Id,
            ReviewerName = review.ReviewerName,
            Score = review.Score,
            Text = review.Text
        };

        public static Context.Models.Review Map(Review review) => new Context.Models.Review
        {
            Id = review.Id,
            ReviewerName = review.ReviewerName,
            Score = review.Score ?? throw new ArgumentException("review score cannot be null.", nameof(review)),
            Text = review.Text
        };

        public static IEnumerable<Restaurant> Map(IEnumerable<Context.Models.Restaurant> restaurants) => restaurants.Select(Map);

        public static IEnumerable<Context.Models.Restaurant> Map(IEnumerable<Restaurant> restaurants) => restaurants.Select(Map);

        public static IEnumerable<Review> Map(IEnumerable<Context.Models.Review> reviews) => reviews.Select(Map);

        public static IEnumerable<Context.Models.Review> Map(IEnumerable<Review> reviews) => reviews.Select(Map);
    }
}
