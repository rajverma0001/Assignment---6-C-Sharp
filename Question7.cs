
//using System;
//using System.Data;
//using Microsoft.Data.SqlClient;

//class Question7
//{
//    static void Main(string[] args)
//    {
//        string cs = @"Server=.\SQLEXPRESS;
//                      Database=CollegeDB;
//                      Integrated Security=True;
//                      TrustServerCertificate=True;";

//        Console.WriteLine("Enter Student ID:");
//        int id = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter Student Name:");
//        string name = Console.ReadLine();

//        Console.WriteLine("Enter Student Age:");
//        int age = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Enter Student Course:");
//        string course = Console.ReadLine();

//        SqlConnection con = new SqlConnection(cs);

//        SqlDataAdapter da = new SqlDataAdapter(
//            "SELECT Id, Name, Age, Course FROM Student", con);

//        DataSet ds = new DataSet();

//        da.Fill(ds, "Student");

//        DataTable dt = ds.Tables["Student"];

//        DataRow row = dt.NewRow();

//        row["Id"] = id;
//        row["Name"] = name;
//        row["Age"] = age;
//        row["Course"] = course;

//        dt.Rows.Add(row);

//        da.InsertCommand = new SqlCommand(
//            @"INSERT INTO Student (Id, Name, Age, Course)
//              VALUES (@Id, @Name, @Age, @Course)", con);

//        da.InsertCommand.Parameters.Add(
//            "@Id", SqlDbType.Int, 0, "Id");

//        da.InsertCommand.Parameters.Add(
//            "@Name", SqlDbType.VarChar, 50, "Name");

//        da.InsertCommand.Parameters.Add(
//            "@Age", SqlDbType.Int, 0, "Age");

//        da.InsertCommand.Parameters.Add(
//            "@Course", SqlDbType.VarChar, 50, "Course");

//        int rows = da.Update(ds, "Student");

//        if (rows > 0)
//        {
//            Console.WriteLine("Student Record Inserted Successfully!");
//        }
//        else
//        {
//            Console.WriteLine("Record Not Inserted!");
//        }

//        da.Dispose();
//        ds.Dispose();
//        con.Dispose();

//        Console.ReadLine();
//    }
//}
