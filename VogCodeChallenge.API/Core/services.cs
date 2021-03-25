using System.Collections.Generic;
using System.Linq;

namespace VogCodeChallenge.API
{
    public class DataServices
    {
        public DataServices(DataContext db) => 
            Employees = new EmployeeService(db);

        public EmployeeService Employees { get; }
    }
    public class EmployeeService
    {
        readonly DataContext _db;

        public EmployeeService(DataContext db) => _db = db;

        public IEnumerable<Employee> GetAll() => _db.Employees;
        public IList<Employee> ListAll() => _db.Employees.ToList();
        public IEnumerable<Employee> GetByDepartment(int departmentId) => _db.Employees.Where(x => x.DepartmentId == departmentId);
    }
}
