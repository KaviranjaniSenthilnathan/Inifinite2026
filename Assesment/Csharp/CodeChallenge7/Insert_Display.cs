using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeADO
{
    internal class Insert_Display
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

        static void InsertEmployee()
        {
            conn = getConnection();

            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Salary:");
            decimal sal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter Type (F/P):");
            string type = Console.ReadLine();

            cmd = new SqlCommand("sp_insertemployee", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@empname", name);
            cmd.Parameters.AddWithValue("@empsal", sal);
            cmd.Parameters.AddWithValue("@emptype", type);

            cmd.ExecuteNonQuery();

            Console.WriteLine("Inserted Successfully");

            conn.Close();
        }

        static void DisplayAll()
        {
            conn = getConnection();

            cmd = new SqlCommand("select * from employee_details", conn);

            dr = cmd.ExecuteReader();

            Console.WriteLine("\nEMPLOYEE LIST");
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
            InsertEmployee();
            DisplayAll();

            Console.Read();
        }
    }
}