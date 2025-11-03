using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class DepartmentMasterDTO
    {
        public int Id { get; set; }

        [Required (ErrorMessage ="{0} is a required field")]
        public string Department { get; set; }
    }
}
