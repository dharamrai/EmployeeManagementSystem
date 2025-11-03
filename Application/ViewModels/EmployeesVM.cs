using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class EmployeesVM
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? DOJ { get; set; }
        public int? SId { get; set; }
        public int? DId { get; set; }
        public int? DeptId { get; set; }
        public string ImgPath { get; set; }
        public bool? IsActive { get; set; }
        public int? Rating { get; set; }
        public int? Salary { get; set; }
    }

    public class EmployeesCommonVM
    {
        public int Id { get; set; }
        public string EName { get; set; }
        public string Gender { get; set; }
        public DateTime? DOB { get; set; }
        public DateTime? DOJ { get; set; }
        public int? SId { get; set; }
        public int? DId { get; set; }
        public int? DeptId { get; set; }
        public string ImgPath { get; set; }
        public bool? IsActive { get; set; }
        public int? Rating { get; set; }
        public int? Salary { get; set; }

        // Custom property
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string DepartmentName { get; set; }
    }
}
