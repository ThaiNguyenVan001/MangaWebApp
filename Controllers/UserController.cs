using Microsoft.AspNetCore.Mvc;

namespace MangaWebApp.Controllers
{
    public class UserController : Controller
    {

        public UserController()
        {
        }
        public IActionResult Create()
        {
            return View("Create");
        }
    }
}
