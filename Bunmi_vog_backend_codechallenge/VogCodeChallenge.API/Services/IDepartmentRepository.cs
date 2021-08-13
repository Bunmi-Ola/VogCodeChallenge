using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public class IDepartmentRepository : DepartmentRepository
    {
        private IList<Department> ListAll;

        public IDepartmentRepository()
        {
            ListAll = new List<Department>()
            {
                new Department(){depatment_ID=101, depatment_Name="Information Technology"},
                new Department(){depatment_ID=102, depatment_Name="Finance"},
                 new Department(){depatment_ID=103, depatment_Name="Human Resource"}
            };
        }

        public IEnumerable<Department> GetAll()
        {
            return ListAll;
        }
    }
}
