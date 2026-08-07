using EmployeeManagement.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetEmployees();

        Task<EmployeeDto> GetEmployeeById(int id);

        Task AddEmployee(CreateEmployeeDto dto);

        Task UpdateEmployee(UpdateEmployeeDto dto);

        Task DeleteEmployee(int id);
    }
}
