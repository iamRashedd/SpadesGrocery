using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class SalesRepo : ISalesRepo<Employee, string, bool>, IAuth<Employee>
    {
        SpadesGroceryEntities db;
        public SalesRepo(SpadesGroceryEntities db)
        {
            this.db = db;
        }

        public Employee Authenticate(string username, string password)
        {
            return db.Employees.FirstOrDefault(x=>x.Email.Equals(username) && x.Password.Equals(password));
        }

        public bool Create(Employee obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetById(string id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Employee obj)
        {
            throw new NotImplementedException();
        }
    }
}
