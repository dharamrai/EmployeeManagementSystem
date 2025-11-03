using Application.DTOs;
using Application.ViewModels;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IDepartmentMasterService:IService<DepartmentMaster, DepartmentMasterDTO, DepartmentMasterVM>
    {
        Task<string> CheckDuplicate(string depname, int id);
        Task<List<DropDownStrVM>> GetDropDown();
    }
}
