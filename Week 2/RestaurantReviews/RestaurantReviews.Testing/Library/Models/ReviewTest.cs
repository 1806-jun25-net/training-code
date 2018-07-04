using RestaurantReviews.Library.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RestaurantReviews.Testing.Library.Models
{
    public class ReviewTest
    {
        [Fact]
        public void ReviewerName_NonEmptyValue_StoresCorrectly()
        {
            const string randomReviewerNameValue = "Al Gore";
            var review = new Review { ReviewerName = randomReviewerNameValue };
            Assert.Equal(randomReviewerNameValue, review.ReviewerName);
        }

        [Fact]
        public void ReviewerName_EmptyValue_ThrowsArgumentException()
        {
            var review = new Review();
            Assert.ThrowsAny<ArgumentException>(() => review.ReviewerName = string.Empty);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(3)]
        [InlineData(10)]
        public void Score_ValueBetween0And10_StoresCorrectly(int scoreValue)
        {
            var review = new Review { Score = scoreValue };
            Assert.Equal(scoreValue, review.Score);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(11)]
        public void Score_ValueNotBetween0And10_ThrowsArgumentException(int scoreValue)
        {
            var review = new Review();
            Assert.ThrowsAny<ArgumentException>(() => review.Score = scoreValue);
        }
    }
}
