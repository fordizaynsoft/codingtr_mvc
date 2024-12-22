using codingtr.Data.Concrete.EfCore;
using codingtr.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using codingtr.Data.Abstract;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.ComponentModel.DataAnnotations;

namespace codingtr.Controllers
{
    public class UserController : Controller
    {
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //Create User
        [HttpPost]
        public IActionResult CreateUser(string Name, string Surname, string Email, string Password)
        {
            if (ModelState.IsValid)
            {
                var payload = new User
                {
                    Name = Name,
                    Surname = Surname,
                    Password = Password,
                    Email = Email,
                    CreatedAt = DateTime.Now,
                    UserRole = "user"

                };
                _userRepository.CreateUser(payload);
                Console.WriteLine("Kayıt Yapıldı");
                return RedirectToAction("Login", "Auth");
            }
            else
            {
                return RedirectToAction("register", "Auth");
            }


        }

    }
}

