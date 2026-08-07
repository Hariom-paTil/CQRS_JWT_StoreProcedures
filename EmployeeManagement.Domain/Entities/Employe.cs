using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain.Entities
{
   public  class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public decimal Salary { get; set; }
    }
}
