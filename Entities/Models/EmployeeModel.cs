using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class EmployeeModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string NID { get; set; }
        public string Type { get; set; }
        public int Salary { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string Picture { get; set; }
    }
}
