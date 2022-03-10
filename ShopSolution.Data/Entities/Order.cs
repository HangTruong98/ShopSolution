﻿using ShopSolution.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopSolution.Data.Entities
{
    public class Order
    {
        public int Id { set; get; }
        public DateTime OrderDate { set; get; }
        public int UserId { set; get; }
        public string ShipName { set; get; }
        public string ShipAddress { set; get; }
        public string ShipEmail { set; get; }
        public int ShipPhoneNumber { set; get; }
        public OrderStatus Status { set; get; }
    }
}
