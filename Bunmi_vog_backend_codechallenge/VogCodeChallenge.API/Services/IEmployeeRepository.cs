using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public class IEmployeeRepository : EmployeeRepository
    {
        private IList<Employee> ListAll;

        public IEmployeeRepository()
        {
            ListAll = new List<Employee>()
            {
                new Employee(){empId= 1, firstName="Joe", lastName="Steve", Department_ID=101, JobTitle="Business Analyst" },
                new Employee(){empId= 1, firstName="John", lastName="David", Department_ID=102, JobTitle="Finance Analyst" },
                new Employee(){empId= 1, firstName="Ghazi", lastName="Sam", Department_ID=101, JobTitle="Software Developer"},

            };
        }

    public IEnumerable<Employee> GetAll()
        {
            return ListAll;
        }

       
    }
}
