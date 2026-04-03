using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using UMS.Data;
using UMS.Models;

namespace UMS.Controllers
{
    [Route("/employees")]
    public class Employees : Controller
    {
        private readonly MyAppContext _context;

        public Employees(MyAppContext context)
        {
            _context = context;
        }

        [HttpGet("getemployees")]
        public IActionResult GetEmployees()
        {
            var employees = _context.Employees
                .Include(e => e.CreatedByUser)
                .ToList();

            return View("GetEmployees", employees);
        }

        [HttpGet("addemployee")]
        public IActionResult AddEmployee()
        {
            PopulateUsers();
            return View("AddEmployee", new Employee());
        }

        [HttpPost("addemployee")]
        [ValidateAntiForgeryToken]
        public IActionResult AddEmployee(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                PopulateUsers();
                return View("AddEmployee", employee);
            }

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return RedirectToAction("GetEmployees");
        }

        private void PopulateUsers()
        {
            var users = _context.Users
                .Select(u => new { u.Id, Name = u.firstName })
                .ToList();

            ViewBag.Users = new SelectList(users, "Id", "Name");
        }
    }
}
