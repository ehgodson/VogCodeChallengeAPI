using System.Collections.Generic;

namespace VogCodeChallenge.API
{
    public class Data
    {
        public Data()
        {
            Employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    DepartmentId = 1,
                    FirstName = "Arthur",
                    LastName = "Parker",
                    JobTitle = "Sales Manager",
                    Address = "2267 Water Street, Kitchener, ON N2H 5A5"
                },
                new Employee
                {
                    Id = 2,
                    DepartmentId = 2,
                    FirstName = "Steve",
                    LastName = "Padilla",
                    JobTitle = "Administrative assistant",
                    Address = "1884 Jasper Ave, Edmonton, AB T5J 3N6"
                },
                new Employee
                {
                    Id = 3,
                    DepartmentId = 1,
                    FirstName = "Joe",
                    LastName = "Lukens",
                    JobTitle = "Associate manager",
                    Address = ""
                },
                new Employee
                {
                    Id = 4,
                    DepartmentId = 2,
                    FirstName = "Richard",
                    LastName = "McCormick",
                    JobTitle = "Project Coordinator",
                    Address = "154 Carling Avenue, Ottawa, ON K1Z 7B5"
                }
            };
            Departments = new List<Department>
            {
                new Department
                {
                    Id = 1,
                    Description = "Sales"
                },
                new Department
                {
                    Id = 2,
                    Description = "Marketing",
                }
            };
        }
        public List<Employee> Employees { get; private set; }
        public List<Department> Departments { get; private set; }
    }
}
