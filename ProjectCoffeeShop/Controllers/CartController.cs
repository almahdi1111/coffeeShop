using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectCoffeeShop.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace ProjectCoffeeShop.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;
        public CartController(AppDbContext context)
        {
            _context = context;
            
        }
        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            if(cart!=null)
            {

                     ViewBag.total = cart.Sum(item => item.items.sell * item.Quantity);
                     ViewBag.Countcartitem=cart.Count();
                    

            }
            return View();
        }

        [Route("buy/{id}")]
        public IActionResult Buy(int id)
        {

           // ProductModel productModel = new ProductModel();
            if (SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart") == null)
            {
                List<CartItem> cart = new List<CartItem>();
                cart.Add(new CartItem { items = _context.items.Single(s => s.Id == id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                SessionHelper.SetValue(HttpContext.Session,"countCartItem", cart.Count().ToString());

            }
            else
            {
                List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new CartItem {items= _context.items.Single(s => s.Id == id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                SessionHelper.SetValue(HttpContext.Session, "countCartItem", cart.Count().ToString());
            }
            return RedirectToAction("Index");
        }
        public IActionResult delete(int id)
        {
            // ProductModel productModel = new ProductModel();
            if (SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart") == null)
            {
                List<CartItem> cart = new List<CartItem>();
                cart.Remove(new CartItem { items = _context.items.Single(s => s.Id == id), Quantity = 1 });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                SessionHelper.SetValue(HttpContext.Session, "countCartItem", cart.Count().ToString());

            }
            else
            {
                List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity--;
                }
                else
                {
                    cart.Remove(new CartItem { items = _context.items.Single(s => s.Id == id), Quantity = 1 });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);
                SessionHelper.SetValue(HttpContext.Session, "countCartItem", cart.Count().ToString());

            }
            return RedirectToAction("Index");
        }
        [Route("remove")]
        public IActionResult Remove()
        {
            List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            cart.Clear();
            SessionHelper.SetObjectAsJson(HttpContext.Session, "cart", cart);

            SessionHelper.SetValue(HttpContext.Session, "countCartItem", cart.Count().ToString());
            ViewBag.cart = null;
            return RedirectToAction("Index");

        }

        private int isExist(int id)
        {
            List<CartItem> cart = SessionHelper.GetObjectFromJson<List<CartItem>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].items.Id.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
