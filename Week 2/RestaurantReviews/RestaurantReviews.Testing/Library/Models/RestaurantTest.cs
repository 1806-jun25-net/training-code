using RestaurantReviews.Library.Models;
using System;
using System.Linq;
using Xunit;

namespace RestaurantReviews.Testing.Library.Models
{
    public class RestaurantTest
    {
        readonly Restaurant restaurant = new Restaurant();

        [Fact]
        public void Name_NonEmptyValue_StoresCorrectly()
        {
            const string randomNameValue = "Komi";
            restaurant.Name = randomNameValue;
            Assert.Equal(randomNameValue, restaurant.Name);
        }

        [Fact]
        public void Name_EmptyValue_ThrowsArgumentException()
        {
            Assert.ThrowsAny<ArgumentException>(() => restaurant.Name = string.Empty);
        }

        [Fact]
        public void Reviews_DefaultValue_Empty()
        {
            Assert.NotNull(restaurant.Reviews);
            Assert.Empty(restaurant.Reviews);
        }

        [Fact]
        public void Score_EmptyReviews_Null()
        {
            Assert.Null(restaurant.Score);
        }

        [Fact]
        public void Score_NullReviews_Null()
        {
            try
            {
                restaurant.Reviews = null;
            }
            catch
            {
                return;
            }
            Assert.Null(restaurant.Score);
        }

        [Theory]
        [InlineData(1, 5)]
        [InlineData(6, 7, 8)]
        public void Score_RestaurantHasReviews_IsAverageValue(params int[] reviewScores)
        {
            foreach (var score in reviewScores)
            {
                restaurant.Reviews.Add(new Review { Score = score });
            }
            var average = reviewScores.Average();
            Assert.Equal(average, restaurant.Score);
        }
    }
}
