using Microsoft.AspNetCore.Mvc;
using vendor_tracker.Models;
using System.Collections.Generic;

namespace vendor_tracker.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/orders/new")]
        public ActionResult New()
        {
            return View();
        } 

        [HttpPost("/orders")]
        public ActionResult Index()
        {
            return View();
        }   
    }
}

// how to have URL path be Order.Name?? 