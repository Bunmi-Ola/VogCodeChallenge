using System;
using System.Collections.Concurrent;
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
                new Employee(){empId= 1, firstName="Joe", lastName="Steve", Department_ID=101, JobTitle="Business Analyst", mailing_address= "1 Uplands drive, Calgary, AB A1A 2B2" },
                new Employee(){empId= 2, firstName="John", lastName="David", Department_ID=102, JobTitle="Finance Analyst",  mailing_address= "300 ring Road, Calgary, AB A5A 2B3" },
                new Employee(){empId= 3, firstName="Ghazi", lastName="Sam", Department_ID=101, JobTitle="Software Developer",  mailing_address= "23rd Avenue, Calgary, AB A3T 1KE"},

            };
        }

        public IEnumerable<Employee> GetAll()
        {
            return ListAll;
        }
      
    }
}
