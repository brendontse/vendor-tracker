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
            List<Vendor> vendorList = Vendor.VendorList;
            return View(vendorList);
        }
        
        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Index(string name, string description)
        {
            Vendor.NewVendor(name, description);
            List<Vendor> vendorList = Vendor.VendorList;
            return View(vendorList);
        }
    }
}