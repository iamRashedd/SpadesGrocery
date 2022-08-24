using DAL;
using DAL.EF;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class OrderService
    {
        public static List<OrderModel> GetAll()
        {
            var data = DataAccessFactory.GetOrderDataAccess().GetAll();
            var orders = new List<OrderModel>();
            foreach(var item in data)
            {
                orders.Add(new OrderModel() { 
                    Order_ID = item.Order_ID, 
                    Customer_ID = item.Customer_ID , 
                    Employee_ID = item.Employee_ID, 
                    Ordered_Products_ID = item.Ordered_Products_ID,
                    Payment = item.Payment,
                    Order_Date = item.Order_Date,
                    Status = item.Status
                    });
            }
            return orders;
        }
        public static OrderModel GetById(int id)
        {
            var data = DataAccessFactory.GetOrderDataAccess().GetById(id);
            var order = new OrderModel()
            {
                Order_ID = data.Order_ID,
                Customer_ID = data.Customer_ID,
                Employee_ID = data.Employee_ID,
                Ordered_Products_ID = data.Ordered_Products_ID,
                Payment = data.Payment,
                Order_Date = data.Order_Date,
                Status = data.Status
            };
            return order;
        }
        public static OrderDetailsModel DetailsById(int id)
        {
            var or = GetById(id);
            var cus = CustomerService.GetByID(or.Customer_ID);
            var emp = EmployeeService.GetById(or.Employee_ID);
            var oPs = OrderedProductsService.GetById(or.Ordered_Products_ID);

            var orderDetails = new OrderDetailsModel()
            {
                order = or,
                customer = cus,
                employee = emp,
                orderedProducts = oPs,
                products = new List<ProductModel>()
            };
            foreach(var p in oPs)
            {
                var p2 = ProductService.GetById(p.Product_ID);
                orderDetails.products.Add(p2);
            }
            return orderDetails;
        } 
        public static List<OrderModel> AllApproved()
        {
            var data = GetAll().Where(x=>x.Status.Equals("Approved")).ToList();
            return data;

        }
        public static List<OrderModel> AllCanceled()
        {
            var data = GetAll().Where(x => x.Status.Equals("Canceled")).ToList();
            return data;

        }
        public static bool ApproveById(int id)
        {
            var data = GetById(id);
            data.Status = "Approved";
            return Update(data);
        }
        public static bool CancelById(int id)
        {
            var data = GetById(id);
            data.Status = "Canceled";
            return Update(data);
        }
        public static List<OrderModel> FilteredByDate(String id)
        {
            var data = GetAll().Where(x => x.Order_Date.ToString().StartsWith(id)).ToList();
            return data;
        }
        public static bool Create(OrderModel or)
        {
            var data = new Order()
            {
                Order_ID = or.Order_ID,
                Customer_ID = or.Customer_ID,
                Employee_ID = or.Employee_ID,
                Ordered_Products_ID = or.Ordered_Products_ID,
                Order_Date = or.Order_Date,
                Payment = or.Payment,
                Status = or.Status
            };
            DataAccessFactory.GetOrderDataAccess().Create(data);
            return true;
        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.GetOrderDataAccess().Delete(id);
        }
        public static bool Update(OrderModel or)
        {
            var order = new Order()
            {
                Order_ID = or.Order_ID,
                Customer_ID = or.Customer_ID,
                Employee_ID = or.Employee_ID,
                Ordered_Products_ID = or.Ordered_Products_ID,
                Order_Date = or.Order_Date,
                Payment = or.Payment,
                Status = or.Status
            };
            var data = DataAccessFactory.GetOrderDataAccess().Update(order);
            return true;
        }
    }
}
