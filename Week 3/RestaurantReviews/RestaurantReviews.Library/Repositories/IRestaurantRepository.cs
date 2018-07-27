using System.Collections.Generic;
using RestaurantReviews.Library.Models;

namespace RestaurantReviews.Library.Repositories
{
    public interface IRestaurantRepository
    {
        void AddRestaurant(Restaurant restaurant);
        void AddReview(Review review, Restaurant restaurant);
        void DeleteRestaurant(int restaurantId);
        void DeleteReview(int reviewId);
        Restaurant GetRestaurantById(int id);
        IEnumerable<Restaurant> GetRestaurants(string search = null);
        void Save();
        void UpdateRestaurant(Restaurant restaurant);
        void UpdateReview(Review review);
    }
}