using DAL;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
        public static List<EmployeeModel> GetAll()
        {
            var data = DataAccessFactory.GetEmployeeDataAccess().GetAll();
            var emps = new List<EmployeeModel>();
            foreach(var emp in data)
            {
                emps.Add(new EmployeeModel()
                {
                    ID = emp.ID,
                    Name = emp.Name,
                    Email = emp.Email,
                    Phone = emp.Phone,
                    NID = emp.NID,
                    Type = emp.Type,
                    Salary = emp.Salary,
                    Address = emp.Address,
                    Picture = emp.Picture,
                    Password = emp.Password

                });
            }
            return emps;
        }
        public static EmployeeModel GetById(int id)
        {
            var data = DataAccessFactory.GetEmployeeDataAccess().GetById(id);
            var emp = new EmployeeModel()
            {
                ID = data.ID,
                Name = data.Name,
                Email = data.Email,
                Phone = data.Phone,
                NID = data.NID,
                Type = data.Type,
                Salary = data.Salary,
                Address = data.Address,
                Password = data.Password,
                Picture = data.Picture
            };
            return emp;
        }
    }
}
