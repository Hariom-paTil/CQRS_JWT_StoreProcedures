using EmployeeManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Employee.Commands
{
    public  class CreateEmployeeCommand : IRequest<bool>
    {
        public CreateEmployeeDto Employee { get; set; }

        public CreateEmployeeCommand(CreateEmployeeDto employee)
        {
            Employee = employee;
        }
    }
}
