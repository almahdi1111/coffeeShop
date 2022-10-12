using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectCoffeeShop.Models;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ProjectCoffeeShop.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<customer> _userManager;
        private readonly SignInManager<customer> _signInManager;
        private readonly AppDbContext _context;


        public AccountController(UserManager<customer> userManager, SignInManager<customer> signInManager, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View( await _context.customers.ToListAsync());
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginMV());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginMV loginVM)
        {
            TempData["Error"] = null;
            if (ModelState.IsValid)
            {
                _ = loginVM.Email;
                var user = await _userManager.FindByEmailAsync(loginVM.Email);
                if (user != null)
                {
                    _ = user.UserName;
                    var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                    if (passwordCheck)
                    {
                        if (await _userManager.IsEmailConfirmedAsync(user))
                        {
                            var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password,false, false);
                            if (result.Succeeded)
                            {
                                return RedirectToAction("index", "Home");
                            }

                        }
                        else
                        {
                            TempData["Error"] = "الرجاء تنشيط الحساب من قبل المسؤول ";
                            return View(loginVM);

                        }

                    }
                    TempData["Error"] = "خطا في كلمة السر او الايميل ";

                    return View(loginVM);
                }
                TempData["Error"] = "خطا في كلمة السر او الايميل ";


                return View(loginVM);
            }
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
           // ViewBag.Regions = new SelectList(await _regions.GetAllAsync(), "Id", "Name");
            return View(new customer());
        }




        [HttpPost]
        public async Task<IActionResult> Register(customer registerVM)
        {
           // ViewBag.Regions = new SelectList(await _context.c.GetAllAsync(), "Id", "Name");
            if (!ModelState.IsValid) return View(registerVM);

            var user = await _userManager.FindByEmailAsync(registerVM.Email);
            if (user != null)
            {
                TempData["Error"] = "المستخدم موجود مسبقا بهذا الايميل";
                return View(registerVM);
            }

            var newUser = new customer()
            {
                FName = registerVM.FName,
                LName = registerVM.LName,
                Email = registerVM.Email,
                UserName = "Customer",
                PhoneNumber = registerVM.PhoneNumber,
                RoleId = 2,
                Password = registerVM.Password,
                EmailConfirmed = true,


            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);

            if (newUserResponse.Succeeded)
            {
                await _userManager.AddToRoleAsync(newUser, UserRoles.Customer);
                TempData["Error"] = null;
            }
            return RedirectToAction("Login", "Account");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }


    }

}
