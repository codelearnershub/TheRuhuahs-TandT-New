using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using TheRuhuahs_TandTNew.Interfaces.Repositories;
using TheRuhuahs_TandTNew.Interfaces.Service;
using TheRuhuahs_TandTNew.Interfaces.ServiceInterface;
using TheRuhuahs_TandTNew.Models;
using TheRuhuahs_TandTNew.Models.ViewModel;

namespace TheRuhuahs_TandTNew.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IUserRepository _userRepository;
        private readonly IBookingService _bookingService;

        public  AuthController(IUserService userService, IRoleService roleService, IUserRepository userRepository, IBookingService bookingService)
        {
            _userService = userService;
            _roleService = roleService;
            _userRepository = userRepository;
            _bookingService = bookingService; 

        }

        public IActionResult Index()
        {

            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {

            _userService.RegisterUser(model);
            var role = _roleService.FindByRoleName("Customer");
            var roles = new List<Role>();
            roles.Add(role);
            model.Roles = roles;
            _userService.RegisterUser(model);
            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            User userLogin = new User
            {
                Email = model.Email,
                Password = model.Password
            };
           User user = _userService.LoginUser(model.Email, model.Password);

            if (user == null)
            {
                ViewBag.Message = "Invalid Email/Password";
                return View();
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email),
                    // new Claim(ClaimTypes.Role, "SuperAdmin")
                };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var props = new AuthenticationProperties();

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props);
               

            }   

            

            /* List<UserRole> userRoles = new List<UserRole>();
             foreach (var use in user.UserRoles)
             {
                Console.WriteLine(use);

             }
             Role role = new Role();
 */
            // UserRole userRole = new UserRole();
            //var userRole = user.UserRoles.ToList();
            var role = _userRepository.FindUserRoles(user.Id);
            if (role.Any(r =>r.RoleId == 1))
                {
                    return RedirectToAction("Index", "SuperAdminDashboard");
                } 
                else if (role.Any(r =>r.RoleId == 2))
                {
                    return RedirectToAction("Index", "AdminDashBoard");
                }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        
               
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }

    }
}