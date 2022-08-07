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
        public Product Create(Product obj)
        {
            throw new NotImplementedException();
        }

        public Product Delete(Product obj)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product obj)
        {
            throw new NotImplementedException();
        }
    }
}
