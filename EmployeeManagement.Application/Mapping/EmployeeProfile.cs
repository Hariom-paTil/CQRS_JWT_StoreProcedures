using AutoMapper;
using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Mapping
{
    public  class EmployeeProfile : Profile //NOTE :: always checked Naming .  one single name can crash your overall work in coding  :(
    {

        public EmployeeProfile()
        {
            CreateMap<Employe, EmployeeDto>(); // i write this line EmployeeManagement.Domain.Entities.Employee 
                                                                                   // because i have Employee class in both Domain and Application layer
                                                                                   // so i need to specify the namespace to avoid ambiguity

            CreateMap<CreateEmployeeDto, Employe>();

            CreateMap<UpdateEmployeeDto, Employe>();
        }
    }
}
