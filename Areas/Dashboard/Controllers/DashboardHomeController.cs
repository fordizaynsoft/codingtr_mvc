using Microsoft.AspNetCore.Mvc;

namespace codingtr.Areas.Dashboard.Controllers
{
    [Area("Dashboard")]
    public class DashboardHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
