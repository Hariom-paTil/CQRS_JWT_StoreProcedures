using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.DTOs
{
    public  class CreateEmployeeDto
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }
    }
}
