using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employe>> GetEmployees();

        Task<Employe> GetEmployeeById(int id);

        Task AddEmployee(Employe employee);

        Task UpdateEmployee(Employe employee);

        Task DeleteEmployee(int id);
    }
}
