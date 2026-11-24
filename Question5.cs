
//using System;
//using System.Data;
//using Microsoft.Data.SqlClient;

//class Question5
//{
//    static void Main(string[] args)
//    {
//        // Connection String
//        string cs = @"Server=.\SQLEXPRESS;
//                      Database=CollegeDB;
//                      Integrated Security=True;
//                      TrustServerCertificate=True;";

//        // Create Connection
//        SqlConnection con = new SqlConnection(cs);

//        // SQL Query
//        string query = "SELECT * FROM Student";

//        // Create SqlDataAdapter
//        SqlDataAdapter da = new SqlDataAdapter(query, con);

//        // Create DataSet
//        DataSet ds = new DataSet();

//        // Fill DataSet
//        da.Fill(ds, "Student");

//        Console.WriteLine("Student Records Retrieved Successfully!");
//        Console.WriteLine();

//        // Display Records
//        DataTable dt = ds.Tables["Student"];

//        foreach (DataRow row in dt.Rows)
//        {
//            Console.WriteLine("ID: " + row["Id"]);
//            Console.WriteLine("Name: " + row["Name"]);
//            Console.WriteLine("Age: " + row["Age"]);
//            Console.WriteLine("Course: " + row["Course"]);

//            Console.WriteLine("----------------------------");
//        }

//        // Release Resources
//        da.Dispose();
//        ds.Dispose();
//        con.Dispose();

//        Console.ReadLine();
//    }
//}

