using Application.ServiceInterfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IDataService _dataservice;
        public IndexModel(IDataService dataserice)
        {
            _dataservice = dataserice;   
        }

        [BindProperty] public List<EmployeesCommonVM> EmployeesCommonVM { get; set; }


        public async Task<IActionResult> OnGet()
        {
            EmployeesCommonVM = await _dataservice.EmployeeMasterService.GetAll();
            return Page();
        }
        
    }
}
