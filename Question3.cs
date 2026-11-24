
//using System;
//using Microsoft.Data.SqlClient;

//class Question3
//{
//    static void Main(string[] args)
//    {
//        // Connection String
//        string cs = @"Server=.\SQLEXPRESS;
//                      Database=CollegeDB;
//                      Integrated Security=True;
//                      TrustServerCertificate=True;";

//        // Take Student ID
//        Console.WriteLine("Enter Student ID to Update:");
//        int id = Convert.ToInt32(Console.ReadLine());

//        // Take Updated Details
//        Console.WriteLine("Enter New Student Name:");
//        string name = Console.ReadLine();

//        Console.WriteLine("Enter New Student Age:");
//        int age = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter New Student Course:");
//        string course = Console.ReadLine();

//        // Create Connection
//        SqlConnection con = new SqlConnection(cs);

//        // Open Connection
//        con.Open();

//        Console.WriteLine("Database Connected Successfully!");

//        // Update Query
//        string query = @"UPDATE Student
//                         SET Name = @name,
//                             Age = @age,
//                             Course = @course
//                         WHERE Id = @id";

//        // Create SqlCommand
//        SqlCommand cmd = new SqlCommand(query, con);

//        // Add Parameters
//        cmd.Parameters.AddWithValue("@id", id);
//        cmd.Parameters.AddWithValue("@name", name);
//        cmd.Parameters.AddWithValue("@age", age);
//        cmd.Parameters.AddWithValue("@course", course);

//        // Execute Query
//        int rows = cmd.ExecuteNonQuery();

//        // Display Result
//        if (rows > 0)
//        {
//            Console.WriteLine("Student Record Updated Successfully!");
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

