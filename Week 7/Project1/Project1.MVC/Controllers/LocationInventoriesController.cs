using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Project1.ContextLibrary;

namespace Project1.MVC.Controllers
{
    public class LocationInventoriesController : Controller
    {
        private readonly Project1Context _context;

        public LocationInventoriesController(Project1Context context)
        {
            _context = context;
        }

        // GET: LocationInventories
        public async Task<IActionResult> Index()
        {
            return View(await _context.LocationInventory.ToListAsync());
        }

        // GET: LocationInventories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationInventory = await _context.LocationInventory
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (locationInventory == null)
            {
                return NotFound();
            }

            return View(locationInventory);
        }

        // GET: LocationInventories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LocationInventories/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LocationId,LocationName,Dough,Pepperoni,Sausage,Bacon,Mushrooms,Olives,Anchovies,Salami,Chicken,Onions,Peppers")] LocationInventory locationInventory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(locationInventory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(locationInventory);
        }

        // GET: LocationInventories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationInventory = await _context.LocationInventory.FindAsync(id);
            if (locationInventory == null)
            {
                return NotFound();
            }
            return View(locationInventory);
        }

        // POST: LocationInventories/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LocationId,LocationName,Dough,Pepperoni,Sausage,Bacon,Mushrooms,Olives,Anchovies,Salami,Chicken,Onions,Peppers")] LocationInventory locationInventory)
        {
            if (id != locationInventory.LocationId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(locationInventory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LocationInventoryExists(locationInventory.LocationId))
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
            return View(locationInventory);
        }

        // GET: LocationInventories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var locationInventory = await _context.LocationInventory
                .FirstOrDefaultAsync(m => m.LocationId == id);
            if (locationInventory == null)
            {
                return NotFound();
            }

            return View(locationInventory);
        }

        // POST: LocationInventories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var locationInventory = await _context.LocationInventory.FindAsync(id);
            _context.LocationInventory.Remove(locationInventory);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LocationInventoryExists(int id)
        {
            return _context.LocationInventory.Any(e => e.LocationId == id);
        }
    }
}
