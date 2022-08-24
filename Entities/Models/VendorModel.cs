using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class VendorModel
    {
        public int Vendor_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int TIN { get; set; }
        public int Product_List_ID { get; set; }
    }
}
