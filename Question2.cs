////Quetion - 2
//using System;
//using Microsoft.Data.SqlClient;

//class Question2
//{
//    static void Main()
//    {
//        string connectionString =
//                           @"Server = .\SQLEXPRESS;
//                           Database = CollegeDB;
//                           Integrated Security = True; 
//                           TrustServerCertificate = True;";
//        SqlConnection con = new SqlConnection(connectionString);
//        con.Open();

//        Console.WriteLine("Database Connected Successfully");
//        Console.WriteLine();

//        string query =
//                   @"INSERT INTO Student(Id, Name, Age, Course)
//                   VALUES(@id, @name, @age, @course)";

//        SqlCommand cmd = new SqlCommand(query, con);
//        cmd.Parameters.AddWithValue("@id", 101);
//        cmd.Parameters.AddWithValue("@name", "Rahul");
//        cmd.Parameters.AddWithValue("@age", 23);
//        cmd.Parameters.AddWithValue("@course", "MCA");

//        int rows = cmd.ExecuteNonQuery();

//        if (rows > 0)
//        {
//            Console.WriteLine("Student inserted successfully");
//        }
//        else
//        {
//            Console.WriteLine("Insertion Failed");
//        }
//        con.Close();
//        cmd.Dispose();
//        con.Dispose();
//    }
//}