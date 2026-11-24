
//using System;
//using Microsoft.Data.SqlClient;

//class Question4
//{
//    static void Main(string[] args)
//    {
//        // Connection String
//        string cs = @"Server=.\SQLEXPRESS;
//                      Database=CollegeDB;
//                      Integrated Security=True;
//                      TrustServerCertificate=True;";

//        // Take Student ID
//        Console.WriteLine("Enter Student ID to Delete:");
//        int id = Convert.ToInt32(Console.ReadLine());

//        // Create Connection
//        SqlConnection con = new SqlConnection(cs);

//        // Open Connection
//        con.Open();

//        Console.WriteLine("Database Connected Successfully!");

//        // Delete Query
//        string query = "DELETE FROM Student WHERE Id = @id";

//        // Create SqlCommand
//        SqlCommand cmd = new SqlCommand(query, con);

//        // Add Parameter
//        cmd.Parameters.AddWithValue("@id", id);

//        // Execute Query
//        int rows = cmd.ExecuteNonQuery();

//        // Display Result
//        if (rows > 0)
//        {
//            Console.WriteLine("Student Record Deleted Successfully!");
//        }
//        else
//        {
//            Console.WriteLine("Student ID Not Found!");
//        }

//        // Close Connection
//        cmd.Dispose();
//        con.Close();

//        Console.ReadLine();
//    }
//}
