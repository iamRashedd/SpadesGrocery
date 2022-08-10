using DAL.EF;
using DAL.Interfaces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static SpadesGroceryEntities db = new SpadesGroceryEntities();
        
        public static ISalesRepo<Order,int,Order> GetOrderDataAccess()
        {
            return new OrderRepo(db);
        }
        public static ISalesRepo<Product,int,Product> GetProductDataAccess()
        {
            return new ProductRepo(db);
        }
        public static ISalesRepo<DeliverySchedule, int, DeliverySchedule> GetDeliveryScheduleDataAccess()
        {
            return new DeliveryScheduleRepo(db);
        }
    }
}
