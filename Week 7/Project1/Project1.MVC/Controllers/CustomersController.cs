using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Project1.ContextLibrary;

namespace Project1.MVC.Controllers
{
    public class CustomersController : Controller
    {
        private readonly Project1Context _context;

        public CustomersController(Project1Context context)
        {
            _context = context;
        }

        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignIn(IFormCollection collection)
        {
            var builder = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = builder.Build();

            var optionsBuilder = new DbContextOptionsBuilder<Project1Context>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Project1"));

            var repo = new PizzaRepos(new Project1Context(optionsBuilder.Options));

            string name = collection["CustomerName"].ToString();

            if (name.Length > 12)
            {
                TempData["Message"] = "Username cannot be longer than 12 characters.";
                return View("SignIn");
            }

            if (collection["CustomerName"] == "Password123")
            {
                TempData["CurrentCustomerName"] = "Mr. President";
                return View("Manager");
            }
            TempData["CurrentCustomerName"] = name;
            if (repo.CheckCustomerName(collection["CustomerName"]))
            {
                return RedirectToAction("PreviousOrder", "PizzaOrders");
            }
            return RedirectToAction("Create", "PizzaOrders");
        }

        public ActionResult Manager()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Manager(IFormCollection collection)
        {
            switch (collection["report"])
            {
                case "Order":
                    return RedirectToAction("Index", "PizzaOrders");

                case "LocOrderHistory":
                    return View("../PizzaOrders/EnterLocation");

                case "UserOrderHistory":
                    return View("../PizzaOrders/EnterCustomerName");

                case "EarliestOrderHistory":
                    return RedirectToAction("IndexEarliest", "PizzaOrders");

                case "LatestOrderHistory":
                    return RedirectToAction("IndexLatest", "PizzaOrders");

                case "PHighOrderHistory":
                    return RedirectToAction("IndexHighest", "PizzaOrders");

                case "PLowOrderHistory":
                    return RedirectToAction("IndexLowest", "PizzaOrders");

                case "LocInv":
                    return RedirectToAction("Index", "LocationInventories");
            }
            return View();
        }

        // GET: Customers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Customer.ToListAsync());
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,CustomerName")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,CustomerName")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(customer);
        }

        // GET: Customers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customer
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customer.FindAsync(id);
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customer.Any(e => e.CustomerId == id);
        }
    }
}
//"../LocationInventories/Index", await _context.LocationInventory.ToListAsync()
