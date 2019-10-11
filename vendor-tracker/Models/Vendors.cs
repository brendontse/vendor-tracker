using System.Collections.Generic;
using System;

namespace vendor_tracker.Models
{
    public class Vendor
    {
        public int ID { get; }
        public string Name {get; set;}
        public string Description {get; set;}
        public List<Order> VendorOrders {get; set;}

        public static List<Vendor> VendorList = new List<Vendor> { };
        public static int VendorNumber { get; set;}


    }
}

