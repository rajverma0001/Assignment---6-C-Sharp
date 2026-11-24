
//using System;
//using System.Data;
//using Microsoft.Data.SqlClient;

//class Question6
//{
//    static void Main(string[] args)
//    {
//        // Connection String
//        string cs = @"Server=.\SQLEXPRESS;
//                      Database=CollegeDB;
//                      Integrated Security=True;
//                      TrustServerCertificate=True;";

//        // Take Student Details
//        Console.WriteLine("Enter Student ID:");
//        int id = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter Student Name:");
//        string name = Console.ReadLine();

//        Console.WriteLine("Enter Student Age:");
//        int age = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter Student Course:");
//        string course = Console.ReadLine();

//        // Create Connection
//        SqlConnection con = new SqlConnection(cs);

//        // Create DataAdapter
//        SqlDataAdapter da = new SqlDataAdapter(
//            "SELECT Id, Name, Age, Course FROM Student", con);

//        // Create DataSet
//        DataSet ds = new DataSet();

//        // Fill DataSet
//        da.Fill(ds, "Student");

//        // Get DataTable
//        DataTable dt = ds.Tables["Student"];

//        // Create New Row
//        DataRow row = dt.NewRow();

//        // Assign Values
//        row["Id"] = id;
//        row["Name"] = name;
//        row["Age"] = age;
//        row["Course"] = course;

//        // Add Row to DataTable
//        dt.Rows.Add(row);

//        // Create Insert Command
//        da.InsertCommand = new SqlCommand(
//            @"INSERT INTO Student (Id, Name, Age, Course)
//              VALUES (@Id, @Name, @Age, @Course)", con);

//        // Add Parameters
//        da.InsertCommand.Parameters.Add(
//            "@Id", SqlDbType.Int, 0, "Id");

//        da.InsertCommand.Parameters.Add(
//            "@Name", SqlDbType.VarChar, 50, "Name");

//        da.InsertCommand.Parameters.Add(
//            "@Age", SqlDbType.Int, 0, "Age");

//        da.InsertCommand.Parameters.Add(
//            "@Course", SqlDbType.VarChar, 50, "Course");

//        // Update Database
//        int rows = da.Update(ds, "Student");

//        // Display Result
//        if (rows > 0)
//        {
//            Console.WriteLine("Student Record Inserted Successfully!");
//        }
//        else
//        {
//            Console.WriteLine("Record Not Inserted!");
//        }

//        // Release Resources
//        da.Dispose();
//        ds.Dispose();
//        con.Dispose();

//        Console.ReadLine();
//    }
//}
