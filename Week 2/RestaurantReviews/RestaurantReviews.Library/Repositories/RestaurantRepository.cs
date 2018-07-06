using RestaurantReviews.Context.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantReviews.Library.Repositories
{
    public class RestaurantRepository
    {
        private readonly RestaurantReviewsDBContext _db;

        public RestaurantRepository(RestaurantReviewsDBContext db)
        {
            _db = db ?? throw new ArgumentNullException(nameof(db));
        }
    }
}
