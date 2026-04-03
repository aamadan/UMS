using Microsoft.AspNetCore.Mvc;
using UMS.Models;
using UMS.Data;

namespace UMS.Controllers
{
    [Route("/users")]
    public class Users : Controller
    {
        private readonly MyAppContext _context;

        public Users(MyAppContext context)
        {
            _context = context;
        }

        [HttpGet("getusers")]
        public IActionResult GetUsers()
        {
            ViewData["title"] = "Users Page";
            var users = _context.Users.ToList();
            return View("GetUsers", users);
        }

        [HttpGet("adduser")]
        public IActionResult AddUser()
        {
            return View("AddUser");
        }

        [HttpPost("adduser")]
        [ValidateAntiForgeryToken]
        public IActionResult AddUser(UsersModel user)
        {
            if (!ModelState.IsValid)
            {
                return View("AddUser", user);
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("GetUsers");
        }
    }
}
