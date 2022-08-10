using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class ProductRepo : ISalesRepo<Product, int, Product>
    {
        SpadesGroceryEntities db;
        public ProductRepo(SpadesGroceryEntities db)
        {
            this.db = db;
        }
        public Product Create(Product obj)
        {
            return db.Products.Add(obj);
        }

        public bool Delete(int id)
        {
            db.Products.Remove(GetById(id));
            db.SaveChanges();
            return true;
        }

        public List<Product> GetAll()
        {
            return db.Products.ToList();
        }

        public Product GetById(int id)
        {
            return db.Products.SingleOrDefault(x => x.Product_ID == id);
        }

        public bool Update(Product obj)
        {
            var old = db.Products.FirstOrDefault(x => x.Product_ID == obj.Product_ID);
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
