using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.API.Models
{
    public class Employee
    {
        public int empId { get; set; }
        public string firstName  { get; set; }
        public string lastName { get; set; }
        public Job Job { get; set; }
        public Department Department { get; set; }
        public string mailing_address { get; set; }
    }
}
