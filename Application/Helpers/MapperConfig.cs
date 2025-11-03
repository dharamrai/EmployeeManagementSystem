using Application.DTOs;
using Application.ViewModels;
using AutoMapper;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Application.Helpers
{
    public class MapperConfig :Profile
    {
        public MapperConfig()
        {
            CreateMap<StateMaster, StateMasterDTO>();
            CreateMap<StateMasterDTO, StateMaster>();
            CreateMap<StateMaster, StateMasterVM>();
            CreateMap<StateMasterVM, DropDownStrVM>()
                .ForMember(des => des.Text, opt => opt.MapFrom(src => src.StateName));

            CreateMap<DistrictMaster, DistrictMasterDTO>();
            CreateMap<DistrictMasterDTO, DistrictMaster>();
            CreateMap<DistrictMaster, DistrictMasterVM>();
            CreateMap<DistrictMasterVM, DropDownStrVM>()
                .ForMember(des=> des.Text, opt=> opt.MapFrom(src=> src.DistrictName));

            CreateMap<DistrictMasterCommon, DistrictMasterCommonVM>();

            CreateMap<DepartmentMaster, DepartmentMasterDTO>();
            CreateMap<DepartmentMasterDTO, DepartmentMaster>();
            CreateMap<DepartmentMaster, DepartmentMasterVM>();
            CreateMap<DepartmentMasterVM, DropDownStrVM>()
                .ForMember(des=> des.Text, opt=> opt.MapFrom(src=> src.Department));

            CreateMap<Employees, EmployeesDTO>();
            CreateMap<EmployeesDTO, Employees>();
            CreateMap<Employees, EmployeesVM>();

            CreateMap<EmployeesCommon, EmployeesCommonVM>();

            CreateMap<DropDownStr, DropDownStrVM>();
        }
    }
}
