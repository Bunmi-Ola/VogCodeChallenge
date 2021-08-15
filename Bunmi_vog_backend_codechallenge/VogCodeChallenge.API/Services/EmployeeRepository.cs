using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    // repository interface  that contains the logic for retrieving data and mapping it to 
    //an entity model
    // It is register with its dependency injection container (IEmployeeRepository)
    //in the Startup.cs file, for use in the controller
    public interface EmployeeRepository
    {
        IEnumerable<Employee> GetAll();
       
    }
}
