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
        public static bool Create(OrderModel or)
        {
            var data = new OrderModel()
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
