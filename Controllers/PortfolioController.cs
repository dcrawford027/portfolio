using Microsoft.AspNetCore.Mvc;

namespace Portfolio_I.Controllers
{
    public class PortfolioController : Controller
    {
        // each route this controller handles
        [HttpGet("")] // type of request
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }

        [HttpPost("makeContact")]
        public IActionResult MakeContact()
        {
            return RedirectToAction("Index");
        }
    }
}