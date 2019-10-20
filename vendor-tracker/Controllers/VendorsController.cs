using Microsoft.AspNetCore.Mvc;
using vendor_tracker.Models;
using System.Collections.Generic;

namespace vendor_tracker.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> vendorList = Vendor.GetVendors();
            return View(vendorList);
        }
        
        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string name, string description)
        {
            Vendor newVendor = new Vendor(name, description);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show (int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.FindVendor(id);
            List<Order> vendorOrders = selectedVendor.VendorOrders;
            model.Add("vendor", selectedVendor);
            model.Add("orders", vendorOrders);
            return View(model);
        }
    }
}