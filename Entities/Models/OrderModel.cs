using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class OrderModel
    {
        public int Order_ID { get; set; }
        public int Customer_ID { get; set; }
        public int Employee_ID { get; set; }
        public int Ordered_Products_ID { get; set; }
        public int Payment { get; set; }
        public System.DateTime Order_Date { get; set; }
        public string Status { get; set; }
    }
}
