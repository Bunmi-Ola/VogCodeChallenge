using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{    

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeesController (EmployeeRepository employeeRepository)
        {
            this._employeeRepository = employeeRepository;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee")]
        public IEnumerable<Employee> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/employees/department/{departmentId}")]        
       // [Route("{Id}")]
        public IEnumerable<Employee> Get(int Id)
        {
            var EmployeeList = _employeeRepository.GetAll().ToList().Where(x => x.Department_ID == Id);
            return EmployeeList;
        }
    }
}
