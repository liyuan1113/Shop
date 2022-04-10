using Microsoft.AspNetCore.Mvc;

namespace Shop.Web.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
