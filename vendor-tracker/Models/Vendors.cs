using System.Collections.Generic;
using System;

namespace vendor_tracker.Models
{
    public class Vendor
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> VendorOrders { get; set; }

        public static List<Vendor> VendorList = new List<Vendor> { };
        public static int VendorNumber { get; set; }
        
        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            VendorOrders = new List<Order> { };
            VendorNumber++;
            Id = VendorNumber;
            VendorList.Add(this);
            VendorOrders = new List<Order>{};
        }
        
        public static List<Vendor> GetVendors()
        {
            return VendorList;
        }        

        public static Vendor FindVendor(int searchId)
        {
            return VendorList[searchId-1];
        }
    }
}

