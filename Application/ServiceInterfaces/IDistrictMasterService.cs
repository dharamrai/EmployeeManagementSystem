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
    public interface IDistrictMasterService:IService<DistrictMaster, DistrictMasterDTO, DistrictMasterVM>
    {
        Task<string> CheckDuplicate(string dname, int id);
        Task<List<DropDownStrVM>> GetDropDown();
        Task<List<DropDownStrVM>> GetDropDownBySid(int sid);
        Task<List<DistrictMasterCommonVM>> GetAll();
    }
}
