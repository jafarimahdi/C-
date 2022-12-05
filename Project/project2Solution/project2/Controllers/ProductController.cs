using Microsoft.AspNetCore.Mvc;

namespace project2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
