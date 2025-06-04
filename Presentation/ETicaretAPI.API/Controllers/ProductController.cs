using Microsoft.AspNetCore.Mvc;

namespace ETicaretAPI.API.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
