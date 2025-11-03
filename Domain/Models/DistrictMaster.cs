using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DistrictMaster
    {
        public int Id { get; set; }
        public int SId { get; set; }
        public string DistrictName { get; set; }
    }
    public class DistrictMasterCommon
    {
        public int Id { get; set; }
        public int SId { get; set; }
        public string DistrictName { get; set; }

        // Custom
        public string StateName { get; set; }
    }
}
