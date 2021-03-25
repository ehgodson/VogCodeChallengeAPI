using System.Collections.Generic;
using System.Linq;

namespace VogCodeChallenge.API
{
    public class DataServices
    {
        public DataServices()
        {
            Data data = new Data();
            Employees = new EmployeeService(data);
        }

        public EmployeeService Employees { get; }
    }
    public class EmployeeService
    {
        readonly Data _data;

        public EmployeeService(Data data)
        {
            _data = data;
        }

        public IEnumerable<Employee> GetAll() => _data.Employees;
        public IList<Employee> ListAll() => _data.Employees.ToList();
        public IEnumerable<Employee> GetByDepartment(int departmentId) => _data.Employees.Where(x => x.DepartmentId == departmentId);
    }
}
