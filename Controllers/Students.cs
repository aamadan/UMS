using Microsoft.AspNetCore.Mvc;
using UMS.Models;
namespace UMS.Controllers
{
    [Route("/students")]
    public class Students : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var students = new StudentsModel
            {
                Id = 1,
                StudentName = "John Doe",
                Bactch = "2024"
            };
            return View("StdPage",students);
        }
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            return Ok(id);
        }
    }
}
