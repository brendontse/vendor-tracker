using Microsoft.AspNetCore.Mvc;

namespace vendor_tracker.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

    }
}