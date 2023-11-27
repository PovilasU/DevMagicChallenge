using TribecaWebAPI.Entities;

namespace TribecaWebAPI.Services.Interfaces
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
    }
}
