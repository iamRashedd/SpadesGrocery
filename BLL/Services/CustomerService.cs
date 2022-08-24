using DAL;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CustomerService
    {
        public static List<CustomerModel> GetAll()
        {
            var data = DataAccessFactory.GetCustomerDataAccess().GetAll();
            var customers = new List<CustomerModel>();
            foreach(var item in data)
            {
                customers.Add(new CustomerModel()
                {
                    ID = item.ID,
                    Name = item.Name,
                    Email = item.Email,
                    Phone = item.Phone,
                    Address = item.Address
                });
            }
            return customers;
        } 
        public static CustomerModel GetByID(int id)
        {
            var data = DataAccessFactory.GetCustomerDataAccess().GetById(id);
            var customer = new CustomerModel()
            {
                ID = data.ID,
                Name = data.Name,
                Email = data.Email,
                Phone = data.Phone,
                Address = data.Address
            };
            return customer;
        }
    }
}
