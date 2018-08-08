using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project1.ContextLibrary;
using Project1.Library;

namespace Project1.MVC.Controllers
{
    public class PizzaOrdersController : Controller
    {
        public PizzaRepos Repo { get; }

        public PizzaOrdersController(PizzaRepos repos)
        {
            Repo = repos;
        }

        // GET: Order
        //[FromQuery]string search = ""
        public ActionResult Index()
        {
            var webOrders = MyOrder();

            return View("Index", webOrders);
        }

        public ActionResult IndexEarliest()
        {
            var webOrders = MyOrder().OrderByDescending(x => x.OrderTime);

            return View("Index", webOrders);
        }

        public ActionResult IndexLatest()
        {
            var webOrders = MyOrder().OrderBy(x => x.OrderTime);

            return View("Index", webOrders);
        }

        public ActionResult IndexHighest()
        {
            var webOrders = MyOrder().OrderByDescending(x => x.OrderCost);

            return View("Index", webOrders);
        }

        public ActionResult IndexLowest()
        {
            var webOrders = MyOrder().OrderBy(x => x.OrderCost);

            return View("Index", webOrders);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IndexLocation(IFormCollection collection)
        {
            var webOrders = MyOrder().Where(x => x.Location.LocationName == collection["Location.LocationName"]);

            return View("Index", webOrders);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult IndexUser(IFormCollection collection)
        {
            int cId = Repo.CheckCustomerId(collection["CustomerName"]);

            var webOrders = MyOrder().Where(x => x.CustomerId == cId);

            return View("Index", webOrders);
        }

        // GET: PizzaOrder/Details/5
        public ActionResult Details(int id)
        {
            var webOrders = MyOrderToppings(id);

            return View(webOrders);
        }

        // GET: PizzaOrder/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PizzaOrder/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Location.InventoryRecall2();
                if (!Location.Check2(collection["Location.LocationName"], collection["PizzaOrderToppings"].ToList()
                    ,collection["Pizza.PizzaSize"], (int)Convert.ToDouble(collection["PizzaQuantity"])))
                {
                    TempData["Message"] = "Not enough inventory at that location to place order.";
                    throw new Exception();
                }

                Location.OrderHistoryRecall2();
                if (!Order.CheckTime2(DateTime.Now,
                    TempData.Peek("CurrentCustomerName").ToString(), collection["Location.LocationName"].ToString()))
                {
                    TempData["Message"] = "You need to wait at least 2 hour before making an order at the same location.";
                    throw new Exception();
                }

                if ((int)Convert.ToDouble(collection["PizzaQuantity"]) > 12 || 
                    (int)Convert.ToDouble(collection["PizzaQuantity"]) < 1)
                {
                    TempData["Message"] = "You can only have a quantity of 1 to 12 pizzas.";
                    throw new Exception();
                }

                if (Order.CalculateCost(collection["Pizza.PizzaSize"],
                    collection["PizzaOrderToppings"].ToList(), Int32.Parse(collection["PizzaQuantity"])) > 500)
                {
                    TempData["Message"] = "Your order cannot cost over $500, please order less pizza.";
                    throw new Exception();
                }

                int cId = Repo.CheckCustomerId(TempData["CurrentCustomerName"].ToString());
                int lId = Repo.LookupLocationId(collection["Location.LocationName"]);
                int pId = Repo.LookupPizzaId(collection["Pizza.PizzaSize"], collection["Pizza.PizzaCrust"]);

                Repo.UpdateLocationInventory(collection["Location.LocationName"], collection["Pizza.PizzaSize"],
                    collection["PizzaOrderToppings"].ToList(), (int)Convert.ToDouble(collection["PizzaQuantity"]));

                Repo.AddPizzaOrder(cId, lId, pId, (int)Convert.ToDouble(collection["PizzaQuantity"]),
                    Order.CalculateCost(collection["Pizza.PizzaSize"],
                    collection["PizzaOrderToppings"].ToList(),
                    (int)Convert.ToDouble(collection["PizzaQuantity"])), DateTime.Now);

                Repo.AddPizzaOrderToppings(collection["PizzaOrderToppings"].ToList());

                

                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                return RedirectToAction("Create");
            }
        }

        public ActionResult PreviousOrder()
        {
            int pId = 0;
            string name = TempData.Peek("CurrentCustomerName").ToString();
            var libraryOrders = Repo.GetPizzaOrders();

            for (int a = 0; a < libraryOrders.Count; a++)
            {
                if (libraryOrders[libraryOrders.Count - a - 1].Customer.CustomerName == name)
                {
                    pId = libraryOrders[libraryOrders.Count - a - 1].PizzaOrderId;
                    break;
                }
            }

            var previous = libraryOrders.Where(x => x.Customer.CustomerName == name).Select(x => new PizzaOrder
            {
                PizzaOrderId = x.PizzaOrderId
            }).Last();

            pId = previous.PizzaOrderId;

            var webOrders = libraryOrders.Where(x => x.PizzaOrderId == pId).Select(x => new PizzaOrder
            {
                PizzaOrderId = x.PizzaOrderId,
                CustomerId = x.CustomerId,
                LocationId = x.LocationId,
                PizzaId = x.PizzaId,
                PizzaQuantity = x.PizzaQuantity,
                OrderCost = x.OrderCost,
                OrderTime = x.OrderTime,
                Customer = libraryOrders.Where(y => y.CustomerId == x.CustomerId).Select(y => new Customer
                {
                    CustomerName = y.Customer.CustomerName
                }).First(),
                Location = libraryOrders.Where(y => y.LocationId == x.LocationId).Select(y => new LocationInventory
                {
                    LocationName = y.Location.LocationName
                }).First(),
                Pizza = libraryOrders.Where(y => y.PizzaId == x.PizzaId).Select(y => new ContextLibrary.Pizza
                {
                    PizzaSize = y.Pizza.PizzaSize,
                    PizzaCrust = y.Pizza.PizzaCrust
                }).First(),
                PizzaOrderToppings = libraryOrders.Where(y => y.PizzaOrderId == x.PizzaOrderId).
                    Select(y => new PizzaOrderToppings
                    {
                        ToppingName = string.Join(", ", y.PizzaOrderToppings.Select(y2 => y2.ToppingName).ToList())
                    })
            }).First();

            TempData["Location"] = webOrders.Location.LocationName;
            TempData["Size"] = webOrders.Pizza.PizzaSize;
            TempData["Crust"] = webOrders.Pizza.PizzaCrust;
            List<string> tempToppings = new List<string> { };
            foreach (var item in webOrders.PizzaOrderToppings)
            {
                tempToppings.Add(item.ToppingName);
            }
            string toppings = tempToppings[0];
            
            TempData["Toppings"] = toppings;
            TempData["Quantity"] = webOrders.PizzaQuantity;

            return View(webOrders);
        }

        // GET: PizzaOrder/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PizzaOrder/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PizzaOrder/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PizzaOrder/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public PizzaOrder MyOrderToppings(int id)
        {
            var libraryOrders = Repo.GetPizzaOrders();

            var webOrders = libraryOrders.Where(x => x.PizzaOrderId == id).Select(x => new PizzaOrder
            {
                PizzaOrderId = x.PizzaOrderId,
                CustomerId = x.CustomerId,
                LocationId = x.LocationId,
                PizzaId = x.PizzaId,
                PizzaQuantity = x.PizzaQuantity,
                OrderCost = x.OrderCost,
                OrderTime = x.OrderTime,
                Customer = libraryOrders.Where(y => y.CustomerId == x.CustomerId).Select(y => new Customer
                {
                    CustomerName = y.Customer.CustomerName
                }).First(),
                Location = libraryOrders.Where(y => y.LocationId == x.LocationId).Select(y => new LocationInventory
                {
                    LocationName = y.Location.LocationName
                }).First(),
                Pizza = libraryOrders.Where(y => y.PizzaId == x.PizzaId).Select(y => new ContextLibrary.Pizza
                {
                    PizzaSize = y.Pizza.PizzaSize,
                    PizzaCrust = y.Pizza.PizzaCrust
                }).First(),
                PizzaOrderToppings = libraryOrders.Where(y => y.PizzaOrderId == x.PizzaOrderId).
                    Select(y => new PizzaOrderToppings
                    {
                        ToppingName = string.Join(", ", y.PizzaOrderToppings.Select(y2 => y2.ToppingName).ToList())
                    })
            }).First();

            return webOrders;
        }

        public IEnumerable<PizzaOrder> MyOrder()
        {
            var libraryOrders = Repo.GetPizzaOrders();

            var webOrders = libraryOrders.Select(x => new PizzaOrder
            {
                PizzaOrderId = x.PizzaOrderId,
                CustomerId = x.CustomerId,
                LocationId = x.LocationId,
                PizzaId = x.PizzaId,
                PizzaQuantity = x.PizzaQuantity,
                OrderCost = x.OrderCost,
                OrderTime = x.OrderTime,
                Customer = libraryOrders.Where(y => y.CustomerId == x.CustomerId).Select(y => new Customer
                {
                    CustomerName = y.Customer.CustomerName,
                }).First(),
                Location = libraryOrders.Where(y => y.LocationId == x.LocationId).Select(y => new LocationInventory
                {
                    LocationName = y.Location.LocationName
                }).First(),
                Pizza = libraryOrders.Where(y => y.PizzaId == x.PizzaId).Select(y => new ContextLibrary.Pizza
                {
                    PizzaId = y.Pizza.PizzaId
                }).First()
            });

            return webOrders;
        }
    }
}