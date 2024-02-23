using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using web.app.Model;

namespace web.app.Pages.ServiceEmployeePages
{
   
    public class AddEmployeeModel : PageModel
    {
         public string Name { get; set; }
        private readonly ILogger<AddEmployeeModel> _logger;
        public AddEmployeeModel(ILogger<AddEmployeeModel> logger)
        {
            //кнцеп
            _logger = logger;
            logger.LogInformation("Created EmployeeList Page");
        }

        public void OnGet()
        {

        }
    }
}
