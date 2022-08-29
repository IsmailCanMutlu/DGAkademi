using AutoMapper;
using W02.Dtos;
using W02.Models;
using W02.PModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W02.Mapper
{


    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<PostEmployeePModel, Employee>();
            CreateMap<Employee, PostEmployeePModel>();
            CreateMap<Employee, EmployeeDtos>();
            CreateMap<EmployeeDtos, Employee>();

            CreateMap<Department, DepartmentDtos>();
            CreateMap<DepartmentDtos, Department>();
            CreateMap<Department, PostDepartmentPModel>();
            CreateMap<PostDepartmentPModel, Department>();

            CreateMap<PostProdactPModel, Prodact>();
            CreateMap<Prodact, PostProdactPModel>();
            CreateMap<Prodact, ProdactDtos>();
            CreateMap<ProdactDtos, Prodact>();
        }
    }

   
}