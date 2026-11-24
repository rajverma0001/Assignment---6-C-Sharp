
//using System;
//using System.Data;
//using Microsoft.Data.SqlClient;

//class Question8
//{
//    static void Main()
//    {
//        string cs = @"Data Source=.\SQLEXPRESS;Initial Catalog=CollegeDB;Integrated Security=True;TrustServerCertificate=True";

//        SqlConnection con = new SqlConnection(cs);

//        Console.Write("Enter Student ID to delete: ");
//        int id = Convert.ToInt32(Console.ReadLine());

//        SqlDataAdapter da = new SqlDataAdapter(
//            "SELECT * FROM Student", con);

//        DataSet ds = new DataSet();

//        da.Fill(ds, "Student");

//        DataTable dt = ds.Tables["Student"]!;

//        DataRow[] rows = dt.Select("Id = " + id);

//        if (rows.Length > 0)
//        {
//            SqlCommandBuilder builder =
//                new SqlCommandBuilder(da);

//            rows[0]!.Delete();

//            da.Update(ds, "Student");

//            Console.WriteLine("Student record deleted successfully!");
//        }
//        else
//        {
//            Console.WriteLine("Student record not found!");
//        }

//        con.Close();
//    }
//}
