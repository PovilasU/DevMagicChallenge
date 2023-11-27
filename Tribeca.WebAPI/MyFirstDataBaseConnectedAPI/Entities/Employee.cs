using System.ComponentModel.DataAnnotations;


namespace TribecaWebAPI.Entities
{
    public class Employee
    {
        //To Create Primary key
        [Key] 
        public int EmployeeId { get; set; }
        public int ClientId { get; set; }
        public int OfficeId { get; set; }
        public string Name  { get; set; }
        public string bio { get; set; }
        public DateOnly DateOfBirth { get; set; }

    }
}
