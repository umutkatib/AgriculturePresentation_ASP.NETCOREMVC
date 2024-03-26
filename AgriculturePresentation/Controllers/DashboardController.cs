using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
