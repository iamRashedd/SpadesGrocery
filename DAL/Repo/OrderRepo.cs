using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class OrderRepo : ISalesRepo<Order, int, Order>
    {
        SpadesGroceryEntities db;
        public OrderRepo(SpadesGroceryEntities db)
        {
            this.db = db;
        }

        public Order Create(Order obj) 
        {
           db.Orders.Add(obj);
           var result = db.SaveChanges();
            if(result != 0)
            {
                return obj;
            }
            return null;
        }

        public bool Delete(int id)
        {
            db.Orders.Remove(GetById(id));
            db.SaveChanges();
            return true;
        }

        public List<Order> GetAll()
        {
            return db.Orders.ToList();
        }

        public Order GetById(int id)
        {
            return db.Orders.SingleOrDefault(o => o.Order_ID == id);
        }

        public bool Update(Order obj)
        {
            var old = db.Orders.FirstOrDefault(x => x.Order_ID == obj.Order_ID);
            if(old != null)
            {
                db.Entry(old).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
