using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Ordered_ProductsModel
    {
        public int Ordered_Products_ID { get; set; }
        public int Product_ID { get; set; }
        public int Quantity { get; set; }
        public int Subtotal { get; set; }
    }
}
