using System.Linq;

namespace VogCodeChallenge.API
{
    public class Employee
    {
        public int Id { get; set; }
        public int DepartmentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JobTitle { get; set; }
        public string Address { get; set; }
    }
    public class Department
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
