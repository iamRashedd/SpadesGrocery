using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class DeliveryModel
    {
        public int ID { get; set; }
        public int Order_ID { get; set; }
        public int DeliveryMan_ID { get; set; }
        public System.DateTime PurchaseDate { get; set; }
        public System.DateTime DeliveryDate { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
    }
}
