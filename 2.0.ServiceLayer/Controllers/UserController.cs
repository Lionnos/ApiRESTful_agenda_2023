using Microsoft.AspNetCore.Mvc;

namespace _2._0.ServiceLayer.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
