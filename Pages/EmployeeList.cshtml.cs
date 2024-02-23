using DB;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using web.app.Model;

namespace web.app.Pages
{
    public class EmployeeListModel : PageModel
    {
        private readonly ILogger<EmployeeListModel> _logger;
        public List<Employee> data { get; set; }
        public EmployeeListModel(ILogger<EmployeeListModel> logger)
        {
            //ЛОГЕР
            _logger = logger;
            logger.LogInformation("Created EmployeeList Page");

            //Чтение и запись данных из базы
            using (var db = new AppDbContext())
            {
                logger.LogInformation("Employees Adding to DB");
                data = db.Employees.ToList();
            }

        }
        public async void OnGet()
        {

        }

        [HttpGet]
        public IActionResult GetEmployee(int id)
        {
            return Page();
        }
    }
}
