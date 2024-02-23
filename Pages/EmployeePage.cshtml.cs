using Microsoft.AspNetCore.Mvc.RazorPages;
using DB;
using System;

namespace web.app.Pages
{
    public class EmployeePageModel : PageModel
    {
        private readonly ILogger<EmployeePageModel> _logger;

        public EmployeePageModel(ILogger<EmployeePageModel> logger)
        {
            _logger = logger;
            logger.LogInformation("Created EmployeePageModel Page");
        }
        public int EmployeeId { get; set; }
        public string employeeName = "";
        public string employeeSurname = "";
        public void OnGet(int employeeId)
        {
            using (var db = new AppDbContext())
            {
                employeeName = db.Employees.Where(emp => emp.Id == employeeId).FirstOrDefault().Name;
                employeeSurname = db.Employees.Where(emp => emp.Id == employeeId).FirstOrDefault().Surname;
            }
        }
    }
}
