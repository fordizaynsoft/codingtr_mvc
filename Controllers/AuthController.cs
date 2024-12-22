using codingtr.Data.Concrete.EfCore;
using codingtr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using codingtr.Data.Abstract;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

namespace codingtr.Controllers
{
    public class AuthController : Controller
    {
        private IUserRepository _userRepository;

        public AuthController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Auth");
        }

        // Kayıt Sayfası ?steği
        public IActionResult Register()
        {
            return View();
        }

        //Login Sayfas? ?stegi
        public IActionResult Login()
        {
            // Login olunmu?mu kontrol� / ise home/?ndex sayfas?na y�nledirme yapar
            if (User.Identity!.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        //Login ??lemi
        [HttpPost]
        public async Task<IActionResult> Login(User model)
        {
            //Kullan?c? ad? ve ?ifre var ve uyumlu ise
            var isUser = _userRepository.User.FirstOrDefault(x => x.Email == model.Email && x.Password == model.Password);
            if (isUser != null)
            {
                var userClaims = new List<Claim>();
                userClaims.Add(new Claim(ClaimTypes.NameIdentifier, isUser.UserId.ToString()));
                userClaims.Add(new Claim(ClaimTypes.Name, isUser.Name ?? ""));
                userClaims.Add(new Claim(ClaimTypes.Email, isUser.Email ?? ""));


                var claimsIdentity = new ClaimsIdentity(userClaims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    IsPersistent = true,
                };
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index", "Home");
            }
            return View(model);


        }


    }
}

