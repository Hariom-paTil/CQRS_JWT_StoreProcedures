using Dapper;
using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly DapperContext _context;

        public EmployeeRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<List<Employe>> GetEmployees()
        {
            using var connection = _context.CreateConnection();

            var result = await connection.QueryAsync<Employe>(
                "sp_GetEmployees",
                commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public async Task<Employe> GetEmployeeById(int id)
        {
            using var connection = _context.CreateConnection();

            return await connection.QueryFirstOrDefaultAsync<Employe>(
                "sp_GetEmployeeById",
                new { Id = id },
                commandType: CommandType.StoredProcedure);
        }

        public async Task AddEmployee(Employe employee)
        {
            using var connection = _context.CreateConnection();

            await connection.ExecuteAsync(
                "sp_AddEmployee",
                new
                {
                    employee.Name,
                    employee.Email,
                    employee.Salary
                },
                commandType: CommandType.StoredProcedure);
        }

        public async Task UpdateEmployee(Employe employee)
        {
            using var connection = _context.CreateConnection();

            await connection.ExecuteAsync(
                "sp_UpdateEmployee",
                new
                {
                    employee.Id,
                    employee.Name,
                    employee.Email,
                    employee.Salary
                },
                commandType: CommandType.StoredProcedure);
        }

        public async Task DeleteEmployee(int id)
        {
            using var connection = _context.CreateConnection();

            await connection.ExecuteAsync(
                "sp_DeleteEmployee",
                new { Id = id },
                commandType: CommandType.StoredProcedure);
        }

    }
}
