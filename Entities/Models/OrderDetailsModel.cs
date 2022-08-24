using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class OrderDetailsModel
    {
        public OrderModel order { get; set; }
        public CustomerModel customer { get; set; }
        public EmployeeModel employee { get; set; }
        public List<Ordered_ProductsModel> orderedProducts { get; set; }
        public List<ProductModel> products { get; set; }

        
    }
}
