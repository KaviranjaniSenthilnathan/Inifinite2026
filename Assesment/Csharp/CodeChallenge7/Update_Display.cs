using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeADO
{
    internal class Update_Display
    {
        public static SqlConnection conn = null;
        public static SqlCommand cmd = null;
        public static SqlDataReader dr = null;

        static SqlConnection getConnection()
        {
            conn = new SqlConnection(
                "Data Source=ICS-LT-F0W37V3\\SQLEXPRESS01;Initial Catalog=EmployeeManagementDB;Integrated Security=true");

            conn.Open();
            return conn;
        }

        static void UpdateSalary()
        {
            conn = getConnection();

            Console.WriteLine("Enter Emp Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            cmd = new SqlCommand("sp_updatesalary", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@empid", id);

            cmd.Parameters.Add("@updatedsalary", SqlDbType.Decimal);
            cmd.Parameters["@updatedsalary"].Direction = ParameterDirection.Output;
            cmd.Parameters["@updatedsalary"].Precision = 10;
            cmd.Parameters["@updatedsalary"].Scale = 2;

            cmd.ExecuteNonQuery();

            Console.WriteLine("Updated Salary = " +
                cmd.Parameters["@updatedsalary"].Value);

            conn.Close();
        }

        static void DisplayUpdated()
        {
            conn = getConnection();

            Console.WriteLine("Enter Emp Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            cmd = new SqlCommand(
                "select * from employee_details where empno=@id",
                conn);

            cmd.Parameters.AddWithValue("@id", id);

            dr = cmd.ExecuteReader();

            Console.WriteLine("\nUPDATED RECORD");
            Console.WriteLine("--------------------");

            while (dr.Read())
            {
                Console.WriteLine(
                    dr["empno"] + " " +
                    dr["empname"] + " " +
                    dr["empsal"] + " " +
                    dr["emptype"]);
            }

            conn.Close();
        }

        static void Main(string[] args)
        {
            UpdateSalary();
            DisplayUpdated();

            Console.Read();
        }
    }
}