using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantReviews.Library.Repositories;
using RestaurantReviews.WebApp.Models;
using Lib = RestaurantReviews.Library.Models;

namespace RestaurantReviews.WebApp.Controllers
{
    public class RestaurantController : Controller
    {
        public IRestaurantRepository Repo { get; }

        public RestaurantController(IRestaurantRepository repo)
        {
            Repo = repo;
        }

        // GET: Restaurant
        public ActionResult Index([FromQuery]string search = "")
        {
            var libRests = Repo.GetRestaurants(search);
            var webRests = libRests.Select(x => new Restaurant
            {
                Id = x.Id,
                Name = x.Name,
                Reviews = x.Reviews.Select(y => new Review
                {
                    ReviewerName = y.ReviewerName,
                    Score = y.Score,
                    Text = y.Text
                })
            });
            return View(webRests);
        }

        // GET: Restaurant/Details/5
        public ActionResult Details(int id)
        {
            var libRest = Repo.GetRestaurantById(id);
            var webRest = new Restaurant
            {
                Name = libRest.Name,
                Reviews = libRest.Reviews.Select(y => new Review
                {
                    ReviewerName = y.ReviewerName,
                    Score = y.Score,
                    Text = y.Text
                })
            };
            return View(webRest);
        }

        // GET: Restaurant/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Restaurant/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Restaurant restaurant)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Repo.AddRestaurant(new Lib.Restaurant
                    {
                        Id = restaurant.Id,
                        Name = restaurant.Name
                    });
                    Repo.Save();

                    return RedirectToAction(nameof(Index));
                }
                return View(restaurant);
            }
            catch
            {
                return View();
            }
        }

        // GET: Restaurant/Edit/5
        public ActionResult Edit(int id)
        {
            var libRest = Repo.GetRestaurantById(id);
            var webRest = new Restaurant
            {
                Name = libRest.Name
            };
            return View(webRest);
        }

        // POST: Restaurant/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([FromRoute]int id, [Bind("Name")]Restaurant restaurant)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var libRest = new Lib.Restaurant
                    {
                        Id = id,
                        Name = restaurant.Name
                    };
                    Repo.UpdateRestaurant(libRest);
                    Repo.Save();

                    return RedirectToAction(nameof(Index));
                }
                return View(restaurant);
            }
            catch (Exception ex)
            {
                return View(restaurant);
            }
        }

        // GET: Restaurant/Delete/5
        public ActionResult Delete(int id)
        {
            var libRest = Repo.GetRestaurantById(id);
            var webRest = new Restaurant
            {
                Name = libRest.Name
            };
            return View(webRest);
        }

        // POST: Restaurant/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Repo.DeleteRestaurant(id);
                Repo.Save();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}