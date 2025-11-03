using Application.ServiceInterfaces;
using Application.Services;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        private readonly IDataService _dataService;
        [BindProperty] public List<EmployeesCommonVM> EmployeesCommonVM { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IDataService dataservice)
        {
            _logger = logger;
            _dataService = dataservice;
        }

        public async Task<IActionResult> OnGet()
        {
            EmployeesCommonVM = await _dataService.EmployeeMasterService.GetAll();
            return Page();
        }
    }
}
