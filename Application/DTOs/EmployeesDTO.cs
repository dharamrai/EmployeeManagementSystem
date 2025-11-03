using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class EmployeesDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} is a required field")]
        public string EName { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        public string Gender { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        public DateTime? DOJ { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        public int? SId { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        public int? DId { get; set; }

        [Required(ErrorMessage = "{0} is a required field")]
        public int? DeptId { get; set; }
        public string ImgPath { get; set; }
        public bool? IsActive { get; set; }

        [Required (ErrorMessage ="{0} is a required field")]
        public int? Rating { get; set; }
        public int? Salary { get; set; }

        // Custom 
        public IFormFile ImgFile { get; set; }
    }
}
