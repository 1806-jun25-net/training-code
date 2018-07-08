using Microsoft.EntityFrameworkCore;
using RestaurantReviews.Context.Models;
using RestaurantReviews.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantReviews.Library.Repositories
{
    public class RestaurantRepository
    {
        private readonly RestaurantReviewsDBContext _db;

        public RestaurantRepository(RestaurantReviewsDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }

        public IEnumerable<Models.Restaurant> GetRestaurants()
        {
            return Mapper.Map(_db.Restaurant.AsNoTracking()).ToList();
        }
    }
}
