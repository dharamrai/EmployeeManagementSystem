using Application.ServiceInterfaces;
using Application.Services;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.Masters.DistrictMaster
{
    public class IndexModel : PageModel
    {
        private readonly IDataService _dataservice;
        public IndexModel(IDataService dataservice)
        {
            _dataservice = dataservice;
        }
        [BindProperty] public List<DistrictMasterCommonVM> modelVm { get; set; }

        public async Task<IActionResult> OnGet()
        {
            modelVm = await _dataservice.DistrictMasterService.GetAll();
            return Page();
        }

    }
}
