using Microsoft.AspNetCore.Mvc;
using ProjectCoffeeShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace ProjectCoffeeShop.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;
        public AdminController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.Countitems = _context.items.Count();
            ViewBag.Countcustomers = _context.customers.Count();
            ViewBag.Countmessages = _context.messages.Count();
            ViewBag.Countorders = _context.orders.Count();

            return View();
        }
    }
}
