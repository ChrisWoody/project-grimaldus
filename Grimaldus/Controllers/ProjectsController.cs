using Microsoft.AspNetCore.Mvc;

namespace Grimaldus.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult ProjectGrimaldus()
        {
            return View();
        }
    }
}