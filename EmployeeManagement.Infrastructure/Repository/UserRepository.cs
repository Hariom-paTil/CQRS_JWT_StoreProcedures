using Dapper;
using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly DapperContext _context;

        public UserRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<User> Login(
            string username,
            string password)
        {
            using var connection =
                _context.CreateConnection();

            string query =
            @"SELECT *
          FROM Users
          WHERE Username=@Username
          AND Password=@Password";

            return await connection
                .QueryFirstOrDefaultAsync<User>(
                    query,
                    new
                    {
                        Username = username,
                        Password = password
                    });
        }
    }
}
