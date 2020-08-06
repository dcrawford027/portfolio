using Microsoft.AspNetCore.Mvc;

namespace Portfolio_I.Controllers
{
    public class PortfolioController : Controller
    {
        // each route this controller handles
        [HttpGet("")] // type of request
        public string Index()
        {
            return "This is my index!";
        }

        [HttpGet("projects")]
        public string Projects()
        {
            return "These are my projects";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my Contact!";
        }
    }
}