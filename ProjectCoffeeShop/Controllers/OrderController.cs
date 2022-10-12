using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectCoffeeShop.Models;
using System.Threading.Tasks;

namespace ProjectCoffeeShop.Controllers
{
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        public OrderController(AppDbContext context)
        {
            _context = context;

        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.orders.Include(s=>s.Items).ToListAsync());
        }
    }
}
