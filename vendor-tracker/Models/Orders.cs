using System.Collections.Generic;
using System;

namespace vendor_tracker.Models
{
    public class Order
    {
        public int ID { get; }
        public string Name {get; set;}
        public string Description {get; set;}
        public float Cost {get; set;}
        public bool CompletedOrder {get; set;}



    }
}