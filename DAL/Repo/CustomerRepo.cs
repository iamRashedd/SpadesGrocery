using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class CustomerRepo : ISalesRepo<Customer, int, Customer>
    {
        SpadesGroceryEntities db;
        public CustomerRepo(SpadesGroceryEntities db)
        {
            this.db = db;
        }
        public Customer Create(Customer obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            return db.Customers.ToList();
        }

        public Customer GetById(int id)
        {
            return db.Customers.SingleOrDefault(x => x.ID == id);
        }

        public bool Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
