using Microsoft.AspNetCore.Mvc;
using vendor_tracker.Models;
using System.Collections.Generic;

namespace vendor_tracker.Controllers
{
    public class OrdersController : Controller
    {

        [HttpGet("/orders")]
        public ActionResult Index()
        {
            return View(Order.OrderList);
        }

        [HttpGet("/orders/new")]
        public ActionResult New()
        {
            return View();
        } 

        [HttpPost("/orders")]
        public ActionResult Create(string name, string description, int price)
        {
            Order newOrder = new Order(name, description, price);
            return RedirectToAction("Index");
        } 

        [HttpGet("/orders/{id}")]
        public ActionResult Show(int id)
        {
            Order foundOrder = Order.FindOrder(id);
            return View(foundOrder);
        }
    }
}
