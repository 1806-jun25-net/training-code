using Microsoft.AspNetCore.Mvc;
using Moq;
using RestaurantReviews.Library.Models;
using WebModels = RestaurantReviews.WebApp.Models;
using RestaurantReviews.Library.Repositories;
using RestaurantReviews.WebApp.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace RestaurantReviews.Testing.WebApp
{
    public class RestaurantControllerTest
    {
        [Fact]
        public void IndexShouldReturnViewWithAllRestaurants()
        {
            // arrange
            var restaurantsList = new List<Restaurant>
            {
                new Restaurant { Id = 1, Name = "Nick's" },
                new Restaurant { Id = 2, Name = "Fred's" }
            };
            var mockRepo = new Mock<IRestaurantRepository>();
            mockRepo.Setup(x => x.GetRestaurants("")).Returns(restaurantsList);
            RestaurantController controller = new RestaurantController(mockRepo.Object);

            // act
            var actionResult = controller.Index();

            // assert
            var view = Assert.IsType<ViewResult>(actionResult);
            var model = Assert.IsAssignableFrom<IEnumerable<WebModels.Restaurant>>
                (view.Model).ToList();
            Assert.Equal(restaurantsList.Count, model.Count);
            for (int i = 0; i < model.Count; i++)
            {
                Assert.Equal(restaurantsList[i].Id, model[i].Id);
                Assert.Equal(restaurantsList[i].Name, model[i].Name);
            }
        }
    }
}
