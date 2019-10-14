using System.Collections.Generic;
using System;

namespace vendor_tracker.Models
{
    public class Order
    {
        public int ID { get; }
        public string Name {get; set;}
        public string Description {get; set;}
        public float Price {get; set;}
        public bool CompletedOrder {get; set;}
        
        public static List<Order> OrderList = new List<Order> { };
        public static int OrderNumber { get; set;}

        public Order(string name, string description, float price)
        {
            Name = name;
            Description = description;
            Price = price;
            OrderNumber++;
            ID = OrderNumber;
            CompletedOrder = false;
            OrderList.Add(this);

        }
    }
}