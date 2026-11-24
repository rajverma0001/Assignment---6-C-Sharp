
//using System;
//using Microsoft.Data.SqlClient;

//class Question1
//{
//    static void Main(string[] args)
//    {
//        // 1. Connection String
//        string cs = @"Server=LAPTOP-R5MFRSGL\SQLEXPRESS;
//                      Database=CollegeDB;
//                      Integrated Security=True;
//                      TrustServerCertificate=True;";

//        // 2. Create Connection
//        SqlConnection con = new SqlConnection(cs);

//        // 3. Open Connection
//        con.Open();

//        Console.WriteLine("Database Connected Successfully!");

//        // 4. SQL Query
//        string query = "SELECT * FROM Student";

//        // 5. Create Command
//        SqlCommand cmd = new SqlCommand(query, con);

//        // 6. Execute Reader
//        SqlDataReader dr = cmd.ExecuteReader();

//        // 7. Display Records
//        while (dr.Read())
//        {
//            Console.WriteLine("ID: " + dr["Id"]);
//            Console.WriteLine("Name: " + dr["Name"]);
//            Console.WriteLine("Age: " + dr["Age"]);
//            Console.WriteLine("Course: " + dr["Course"]);

//            Console.WriteLine("----------------------");
//        }

//        // 8. Close Resources
//        dr.Close();
//        cmd.Dispose();
//        con.Close();

//        Console.ReadLine();
//    }
//}
