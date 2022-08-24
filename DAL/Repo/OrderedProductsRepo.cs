using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class OrderedProductsRepo : ISalesRepo<Ordered_Products, int, Ordered_Products>
    {
        SpadesGroceryEntities db;
        public OrderedProductsRepo(SpadesGroceryEntities db)
        {
            this.db = db;
        }

        public Ordered_Products Create(Ordered_Products obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Ordered_Products> GetAll()
        {
            return db.Ordered_Products.ToList();
        }

        public Ordered_Products GetById(int id)
        {
            return db.Ordered_Products.FirstOrDefault(x => x.Ordered_Products_ID == id);
        }

        public bool Update(Ordered_Products obj)
        {
            throw new NotImplementedException();
        }
    }
}
