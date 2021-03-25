using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("api/employees")]
    public class EmployeesController : ControllerBase
    {
        readonly DataServices _services;

        public EmployeesController(DataServices services)
        {
            _services = services;
        }

        [HttpGet]
        public IEnumerable<Employee> Get() => _services.Employees.GetAll();

        [HttpGet("department/{id}")]
        public IEnumerable<Employee> GetByDepartment(int id) => 
            _services.Employees.GetByDepartment(id);
    }
}