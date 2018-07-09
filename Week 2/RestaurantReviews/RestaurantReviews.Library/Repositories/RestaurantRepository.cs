using Microsoft.EntityFrameworkCore;
using RestaurantReviews.Context.Models;
using RestaurantReviews.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantReviews.Library.Repositories
{
    /// <summary>
    /// A repository managing data access for restaurant objects and their review members.
    /// </summary>
    public class RestaurantRepository
    {
        private readonly RestaurantReviewsDBContext _db;

        /// <summary>
        /// Initializes a new restaurant repository given a suitable Entity Framework DbContext.
        /// </summary>
        /// <param name="db">The DbContext</param>
        public RestaurantRepository(RestaurantReviewsDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        /// <summary>
        /// Get all restaurants with deferred execution.
        /// </summary>
        /// <returns>The collection of restaurants</returns>
        public IEnumerable<Models.Restaurant> GetRestaurants()
        {
            // disable pointless tracking for performance
            return Mapper.Map(_db.Restaurant.Include(r => r.Review).AsNoTracking());
        }

        /// <summary>
        /// Add a restaurant, including any associated reviews.
        /// </summary>
        /// <param name="restaurant">The restaurant</param>
        public void AddRestaurant(Models.Restaurant restaurant)
        {
            _db.Add(Mapper.Map(restaurant));
        }

        /// <summary>
        /// Delete a restaurant by ID. Any reviews associated to it will not be deleted.
        /// </summary>
        /// <param name="restaurantId">The ID of the restaurant</param>
        public void DeleteRestaurant(int restaurantId)
        {
            _db.Remove(_db.Restaurant.Find(restaurantId));
        }

        /// <summary>
        /// Update a restaurant. Will not process any changes to its reviews.
        /// </summary>
        /// <param name="restaurant">The restaurant with changed values</param>
        public void UpdateRestaurant(Models.Restaurant restaurant)
        {
            // calling Update would mark every property as Modified.
            // this way will only mark the changed properties as Modified.
            _db.Entry(_db.Review.Find(restaurant.Id)).CurrentValues.SetValues(Mapper.Map(restaurant));
        }

        /// <summary>
        /// Add a review, and optionally associate it with a restaurant.
        /// </summary>
        /// <param name="review">The review</param>
        /// <param name="restaurant">The restaurant (or null if none)</param>
        public void AddReview(Models.Review review, Models.Restaurant restaurant)
        {
            if (restaurant != null)
            {
                // get the db's version of that restaurant
                // (can't use Find with Include)
                var contextRestaurant = _db.Restaurant.Include(r => r.Review).First(r => r.Id == restaurant.Id);
                restaurant.Reviews.Add(review);
                contextRestaurant.Review.Add(Mapper.Map(review));
            }
            else
            {
                _db.Add(Mapper.Map(review));
            }
        }

        /// <summary>
        /// Delete a review by ID.
        /// </summary>
        /// <param name="reviewId">The ID of the review</param>
        public void DeleteReview(int reviewId)
        {
            _db.Remove(_db.Review.Find(reviewId));
        }

        /// <summary>
        /// Update a review.
        /// </summary>
        /// <param name="review">The review with changed values</param>
        public void UpdateReview(Models.Review review)
        {
            _db.Entry(_db.Review.Find(review.Id)).CurrentValues.SetValues(Mapper.Map(review));
        }

        /// <summary>
        /// Persist changes to the data source.
        /// </summary>
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
