using System;
using System.Collections.Generic;
using System.Text;

namespace VogCodeChallenge.API.Models
{
    public class Employee
    {
        public Employee() { }
        public Employee(int EmpID, string FirstName, string LastName, string job_Title,
                        int DeptID, string Mailing_address)
        {
            empId = EmpID;
            firstName = FirstName;
            lastName = LastName;
            JobTitle = job_Title;
            Department_ID = DeptID;
            mailing_address = Mailing_address;
        }

        public int empId { get; set; }
        public string firstName  { get; set; }
        public string lastName { get; set; }
        public string JobTitle { get; set; }
        public int Department_ID { get; set; }
        public string mailing_address { get; set; }
    }
}
