using AutoMapper;
using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _repository;
        private readonly IMapper _mapper;

        public EmployeeService(
            IEmployeeRepository repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<EmployeeDto>> GetEmployees()
        {
            var employees =
                await _repository.GetEmployees();

            return _mapper.Map<List<EmployeeDto>>(employees);
        }

        public async Task<EmployeeDto> GetEmployeeById(int id)
        {
            var employee =
                await _repository.GetEmployeeById(id);

            return _mapper.Map<EmployeeDto>(employee);
        }

        public async Task AddEmployee(CreateEmployeeDto dto)
        {
            var employee =
                _mapper.Map<Employe>(dto);

            await _repository.AddEmployee(employee);
        }

        public async Task UpdateEmployee(UpdateEmployeeDto dto)
        {
            var employee =
                _mapper.Map<Employe>(dto);

            await _repository.UpdateEmployee(employee);
        }

        public async Task DeleteEmployee(int id)
        {
            await _repository.DeleteEmployee(id);
        }

    }
}
