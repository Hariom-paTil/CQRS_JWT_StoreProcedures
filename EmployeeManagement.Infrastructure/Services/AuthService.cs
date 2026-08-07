using EmployeeManagement.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public AuthService(
            IUserRepository userRepository,
            ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public async Task<string> Login(
            string username,
            string password)
        {
            var user =
                await _userRepository
                .Login(username, password);

            if (user == null)
                return null;

            return _tokenService.GenerateToken(
                user.Username,
                user.Role);
        }
    }
}
