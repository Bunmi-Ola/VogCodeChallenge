using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public interface EmployeeRepository
    {
        IEnumerable<Employee> GetAll();
       
    }
}
