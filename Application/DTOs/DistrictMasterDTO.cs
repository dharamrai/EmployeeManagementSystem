using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class DistrictMasterDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="{0} is a required field")]
        [DisplayName("State name")]
        public int SId { get; set; }

        [Required(ErrorMessage ="{0} is a required field")]
        public string DistrictName { get; set; }
    }
}
