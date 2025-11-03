using Application.DTOs;
using Application.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Website.Pages.Employees
{
    public class ManageModel : PageModel
    {

        private readonly IDataService _dataService;
        private readonly IWebHostEnvironment _webhost;
        [BindProperty(SupportsGet =true)] public int id { get; set; }
        [BindProperty] public bool isNew { get; set; } = true;
        [BindProperty] public EmployeesDTO modelDto { get; set; }
       
        public ManageModel(IDataService dataservice, IWebHostEnvironment webhost)
        {
            _dataService = dataservice;
            _webhost = webhost;
        }
        
        public async Task<IActionResult> OnGet()
        {
            if(id>0)
            {
                isNew = false;
                modelDto = await _dataService.EmployeeMasterService.Get(id);
                var dlist = await _dataService.DistrictMasterService.GetDropDownBySid((int)modelDto.SId);
               
                if(dlist != null)
                {
                    ViewData["districts"] = new SelectList(dlist, "Id", "Text", modelDto.DId);
                }
               
            }
            else
            {
                isNew = true;
                modelDto = new EmployeesDTO();
            }
            var stateResult = await _dataService.StateMasterService.GetDropDown();
            if(stateResult!=null)
            {
                ViewData["states"] = new SelectList(stateResult, "Id", "Text", modelDto.SId);
            }

            var departmentResult = await _dataService.DepartmentMasterService.GetDropDown();
            if(departmentResult!=null)
            {
                ViewData["departments"] = new SelectList(departmentResult, "Id", "Text", modelDto.DeptId);
            }

            return Page();
        }


        public async Task<JsonResult> OnGetDistricts(int sid)
        {
            if(sid>0)
            {
                var dList = await _dataService.DistrictMasterService.GetDropDownBySid(sid);
                return new JsonResult(dList);
            }
            return new JsonResult(new List<object>());
        }

        public async Task<IActionResult> OnPostCreate()
        {
            var uploadedFile = Request.Form.Files.FirstOrDefault();
            if(uploadedFile!=null)
            {
                modelDto.ImgPath = await GetFileName(uploadedFile, modelDto.ImgPath);
            }

            if(modelDto.Id>0)
            {
                var result = await _dataService.EmployeeMasterService.Update(modelDto);
                if(result!=null)
                {
                    TempData["Notification"] = "Record updated successfully";                    
                }
                else
                {
                    TempData["Notification"] = "Failed to update record";
                }
            }
            else
            {
                var result = await _dataService.EmployeeMasterService.Create(modelDto);
                if (result != null)
                {
                    TempData["Notification"] = "Record saved successfully";
                }
                else
                {
                    TempData["Notification"] = "Failed to save record";
                }
            }

            return RedirectToPage("Index");
        }

        public async Task<string> GetFileName(IFormFile uploadedPhoto, string oldImage)
        {
            if(uploadedPhoto ==null && oldImage!=null)
            {
                return oldImage;
            }

            string uploadFolder = Path.Combine(_webhost.WebRootPath, "ProfilePhoto");
            if(!Directory.Exists(uploadFolder))
            {
                Directory.CreateDirectory(uploadFolder);
            }
            string guid = Guid.NewGuid().ToString("N");
            string uniqueFileName = guid.Substring(0,6) + "_" + uploadedPhoto.FileName;
            string filePath = Path.Combine(uploadFolder, uniqueFileName);

            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                await uploadedPhoto.CopyToAsync(fileStream);
            };

            if(oldImage!=null)
            {
                string oldFilePath = Path.Combine(uploadFolder, oldImage);
                if (System.IO.File.Exists(oldFilePath))
                {
                    System.IO.File.Delete(oldFilePath);
                }
            }
           return uniqueFileName;

        }

    }
}
