using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class DistrictMasterVM
    {
        public int Id { get; set; }
        public int SId { get; set; }
        public string DistrictName { get; set; }
    }

    public class DistrictMasterCommonVM
    {
        public int Id { get; set; }
        public int SId { get; set; }
        public string DistrictName { get; set; }

        // Custom
        public string StateName {  get; set; }
    }
}
