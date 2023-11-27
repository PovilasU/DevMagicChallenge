using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TribecaWebAPI.Services.Implementation;
using TribecaWebAPI.Services.Interfaces;

namespace TribecaWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        public EmployeesController(IEmployeeService employeeService)
        {
        
            this.employeeService = employeeService;
        }
        

        [HttpGet]

        public IActionResult GetEmployees()
        {
            var result = employeeService.GetAllEmployees();
            return Ok(result);
        }

    }
}
