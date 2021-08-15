using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;
using VogCodeChallenge.API.Services;

namespace VogCodeChallenge.API.Controllers
{
    //Q4: RESTful API controller for employees and provide these two endpoints

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        public EmployeesController(EmployeeRepository employeelist)
        {
            _employeelist = employeelist;
        }
        public EmployeeRepository _employeelist { get; set; }

        [HttpGet]       
        public IEnumerable<Employee> GetAll()
        {
            
            return _employeelist.GetAll().ToList();          
        }


        [HttpGet("{department}/{id}")]        
        [Route("GetEmployeeByDepartmentId")]       
        public IEnumerable<Employee> Get(int Id)
        {

            var EmployeeList = _employeelist.GetAll().ToList().Where(x => x.Department_ID == Id);
            return EmployeeList;
        }
    }
}
