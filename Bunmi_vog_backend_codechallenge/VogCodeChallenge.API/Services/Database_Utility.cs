using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using VogCodeChallenge.API.Models;

namespace VogCodeChallenge.API.Services
{
    public class Database_Utility : EmployeeRepository
    {
       
        public IEnumerable<Employee> GetAll()
        {
            return GetAllEmployee();
        }

        public IList<Employee> GetAllEmployee()
        {
            IList<Employee> getAll = new List<Employee>();
            var i = 0;
            SqlConnection con = SqlHelper.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Employee_Table INNER JOIN department_Table " +
                "ON Employee_Table.DeptID = department_Table.DeptID; ";
            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    i = i + 1;
                    getAll.Add(new Employee(
                         (int)reader["id"],
                        (string)reader["FirstName"],
                        (string)reader["LastName"],
                        (string)reader["job_Title"],
                        (int)reader["DeptID"],
                         (string)reader["Mailing_address"]
                      ));
                }
            }
            return getAll;
        }

        public Employee getEmployeeByDeptID(int id)
        {
            List<Employee> employee = new List<Employee>();

            SqlConnection con = SqlHelper.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Employee_Table where id=@ID";

            cmd.Parameters.AddWithValue("ID", id);

            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employee.Add(new Employee(
                         (int)reader["id"],
                        (string)reader["FirstName"],
                        (string)reader["LastName"],
                        (string)reader["job_Title"],
                        (int)reader["DeptID"],
                         (string)reader["Mailing_address"]
                    ));
                }
            }
            return employee[0];

        }

        public Employee getEmployeeByID(int id)
        {
            List<Employee> employee = new List<Employee>();

            SqlConnection con = SqlHelper.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM Employee_Table where id=@ID";

            cmd.Parameters.AddWithValue("ID", id);

            using (con)
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    employee.Add(new Employee(
                         (int)reader["id"],
                        (string)reader["FirstName"],
                        (string)reader["LastName"],
                        (string)reader["job_Title"],
                        (int)reader["DeptID"],
                         (string)reader["Mailing_address"]
                    ));
                }
            }
            return employee[0];

        }
        public void EmployeeInsert(Employee employee)
        {

            SqlConnection con = SqlHelper.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "INSERT INTO Employee_Table(FirstName, LastName, job_Title, DeptID, Mailing_address)" +
                " VALUES(@firstName, @lastName, @Job_Title, @DeptID, @Mailing_address)";
            cmd.Parameters.AddWithValue("@firstName", employee.firstName);
            cmd.Parameters.AddWithValue("@lastName", employee.lastName);
            cmd.Parameters.AddWithValue("@Job_Title", employee.JobTitle);
            cmd.Parameters.AddWithValue("@DeptID", employee.Department_ID);
            cmd.Parameters.AddWithValue("@Mailing_address", employee.mailing_address);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void EmployeeUpdate(Employee employee)
        {
            SqlConnection con = SqlHelper.GetConnection();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "UPDATE Employee_Table SET FirstName=@firstName,LastName=@lastName, " +
                "job_Title=@Job_Title, DeptID=@DeptID,   Mailing_address=@Mailing_address WHERE id =@ID";
            cmd.Parameters.AddWithValue("@firstName", employee.firstName);
            cmd.Parameters.AddWithValue("@lastName", employee.lastName);
            cmd.Parameters.AddWithValue("@Job_Title", employee.JobTitle);
            cmd.Parameters.AddWithValue("@DeptID", employee.Department_ID);
            cmd.Parameters.AddWithValue("@Mailing_address", employee.mailing_address);
            cmd.Parameters.AddWithValue("@ID", employee.empId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void EmployeeToDelete(int id)
        {
            SqlConnection con = SqlHelper.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "DELETE FROM Employee_Table WHERE id=@Id";

            cmd.Parameters.AddWithValue("@Id", id);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
