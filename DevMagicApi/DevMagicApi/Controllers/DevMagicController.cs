using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevMagicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevMagicController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<DevMagic>>>GetEmployees()
        {
            return new List<DevMagic> {
                new DevMagic
                {
                    EmployeeID = 3,
                    ClientID = 2,
                    OfficeID = 3,
                    Name = "John Fisher",
                    Bio = "Flowers are great!",
                    DateOfBirth = "2001-02-11",

                }
            };
        }
    }
}


