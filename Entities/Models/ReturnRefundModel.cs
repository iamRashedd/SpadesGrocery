using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class ReturnRefundModel
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int Customer_ID { get; set; }
        public int Order_ID { get; set; }
        public string Issue { get; set; }
    }
}
