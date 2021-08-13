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
        public string JobTitle { get; set; }
        public int Department_ID { get; set; }
        public string mailing_address { get; set; }
    }
}
