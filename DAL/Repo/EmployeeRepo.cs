using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class EmployeeRepo : ISalesRepo<Employee, int, Employee>
    {
        SpadesGroceryEntities db;
        public EmployeeRepo(SpadesGroceryEntities db)
        {
            this.db = db;
        }

        public Employee Create(Employee obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            return db.Employees.ToList();
        }

        public Employee GetById(int id)
        {
            return db.Employees.SingleOrDefault(x => x.ID == id);
        }

        public bool Update(Employee obj)
        {
            throw new NotImplementedException();
        }
    }
}
