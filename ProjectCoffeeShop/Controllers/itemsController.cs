using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectCoffeeShop.Models;
using ProjectCoffeeShop.Services;

namespace ProjectCoffeeShop.Controllers
{
    public class itemsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _hosting;


        public itemsController(AppDbContext context,IWebHostEnvironment hosting)
        {
            _context = context;
            _hosting = hosting;
        }

        // GET: items
        public async Task<IActionResult> Index()
        {

            return View(await _context.items.Include(s=>s.CoffeeStrength).ToListAsync());
        }

      
        public IActionResult Create()
        {
            ViewBag.coffeeStrengths = new SelectList( _context.coffeeStrengths.ToList(), "Id", "Strength");
            return View();
        }

        // POST: items/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(items items)
        {
            ViewBag.coffeeStrengths = new SelectList(await _context.coffeeStrengths.ToListAsync(), "Id", "Strength");

           if (Request.Form.Files.Count > 0)
           {
                var file = Request.Form.Files.FirstOrDefault();
                string pathUpload = Path.Combine(_hosting.WebRootPath, "img/shop_coffee");
                items.ImagePath = UploadFileHelper.UploadFile(file, pathUpload, items.ImagePath);
            }
            if (ModelState.IsValid)
            {
                _context.Add(items);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(items);
        }

        // GET: items/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            ViewBag.coffeeStrengths = new SelectList(_context.coffeeStrengths.ToList(), "Id", "Strength");
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.items.FindAsync(id);
            if (items == null)
            {
                return NotFound();
            }
            return View(items);
        }

        // POST: items/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, items items)
        {
            ViewBag.coffeeStrengths = new SelectList(_context.coffeeStrengths.ToList(), "Id", "Strength");
            if (Request.Form.Files.Count > 0)
            {
                var file = Request.Form.Files.FirstOrDefault();
                string pathUpload = Path.Combine(_hosting.WebRootPath, "img/shop_coffee");
                items.ImagePath = UploadFileHelper.UploadFile(file, pathUpload, items.ImagePath);
            }
            if (id != items.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(items);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!itemsExists(items.Id))
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
            return View(items);
        }

        // GET: items/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var items = await _context.items
                .FirstOrDefaultAsync(m => m.Id == id);
            if (items == null)
            {
                return NotFound();
            }

            return View(items);
        }

        // POST: items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var items = await _context.items.FindAsync(id);
            _context.items.Remove(items);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool itemsExists(int id)
        {
            return _context.items.Any(e => e.Id == id);
        }
    }
}
