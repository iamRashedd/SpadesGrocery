using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class VendorRepo : ISalesRepo<Vendor, int, Vendor>
    {
        public Vendor Create(Vendor obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Vendor> GetAll()
        {
            throw new NotImplementedException();
        }

        public Vendor GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Vendor obj)
        {
            throw new NotImplementedException();
        }
    }
}
