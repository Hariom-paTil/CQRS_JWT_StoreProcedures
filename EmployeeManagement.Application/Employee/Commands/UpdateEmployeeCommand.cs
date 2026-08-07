using EmployeeManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Employee.Commands
{
    public  class UpdateEmployeeCommand : IRequest<bool>
    {
        public UpdateEmployeeDto Employee { get; set; }

        public UpdateEmployeeCommand(UpdateEmployeeDto employee)
        {
            Employee = employee;
        }
    }
}
