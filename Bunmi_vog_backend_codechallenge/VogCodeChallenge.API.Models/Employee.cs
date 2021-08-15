using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VogCodeChallenge.API.Models
{
    //The employee class has been created in a class library so that it can be reusable accross 
    //.net applications. This class can be use by referencing its DLL file
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

        [Required]
        [StringLength(10)]
        public string firstName  { get; set; }

        [Required]
        [StringLength(10)]
        public string lastName { get; set; }

        [Required]
        [StringLength(10)]
        public string JobTitle { get; set; }

        [Required]        
        public int Department_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string mailing_address { get; set; }
    }
}
