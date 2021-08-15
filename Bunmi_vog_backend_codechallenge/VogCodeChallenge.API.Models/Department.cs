using System;

namespace VogCodeChallenge.API.Models
{
    //The employee class has been created in a class library so that it can be reusable accross 
    //.net applications. This class can be use by referencing its DLL file
    public class Department
    {
        public int depatment_ID { get; set; }
        public string depatment_Name { get; set; }
             
    }
}
