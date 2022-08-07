﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ProductModel
    {
        public int Product_ID { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }
        public int Vendor_ID { get; set; }
        public string Description { get; set; }
    }
}