using System.Collections.Generic;
using System;

namespace vendor_tracker.Models
{
    public class Vendor
    {
        public int ID { get; }
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
            ID = VendorNumber;
            VendorList.Add(this);
        }
        
        public static void NewVendor(string name, string description)
        {
            if (name != null)
            {
                bool VendorCreated = false;

                foreach(Vendor vendor in VendorList)
                    if (vendor.Name == name)
                    {
                        VendorCreated = true;
                        // return to user that a vendor with that name has already been created
                    }
                if (VendorCreated == false)
                {
                     Vendor vendor = new Vendor (name, description);
                }
            }
        }
    }
}

