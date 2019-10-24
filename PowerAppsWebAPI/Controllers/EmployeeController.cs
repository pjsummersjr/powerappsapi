using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace PowerAppsWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [SwaggerOperation("GetEmployees", "Returns a collection of Employee objects")]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        public class Employee
        {
            public string ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Title { get; set; }
        }

        static List<Employee> employees = new List<Employee>()
        {
            new Employee() { ID = "01", FirstName = "Paul", LastName = "Summers", Title = "CEO"},
            new Employee() { ID = "02", FirstName = "Stacey", LastName = "Summers", Title = "CMO"},
            new Employee() { ID = "03", FirstName = "Brennan", LastName = "Summers", Title = "CTO"},
            new Employee() { ID = "04", FirstName = "Kieran", LastName = "Summers", Title = "CFO"}
        }; 
    }
}