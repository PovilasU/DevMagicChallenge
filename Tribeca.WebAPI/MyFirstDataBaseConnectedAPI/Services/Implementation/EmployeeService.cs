using TribecaWebAPI.Context;
using TribecaWebAPI.Entities;
using TribecaWebAPI.Services.Interfaces;

namespace TribecaWebAPI.Services.Implementation
{

    public class EmployeeService : IEmployeeService
    {
        private TribecaDbContext dbContext;

        // Constructor
        public EmployeeService(TribecaDbContext context)
        {
            dbContext = context;
        }

        public List<Employee> GetAllEmployees()
        {
            return dbContext.Employees.ToList();
        }
    }

}
