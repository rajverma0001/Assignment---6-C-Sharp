
//using System;
//using System.Data;
//using Microsoft.Data.SqlClient;

//class Question9
//{
//    static void Main()
//    {
//        string cs = @"Data Source=.\SQLEXPRESS;
//                      Initial Catalog=CollegeDB;
//                      Integrated Security=True;
//                      TrustServerCertificate=True";

//        SqlConnection con = new SqlConnection(cs);

//        SqlDataAdapter da = new SqlDataAdapter(
//            "SELECT * FROM Student", con);

//        DataSet ds = new DataSet();

//        da.Fill(ds, "Student");

//        SqlCommandBuilder cb = new SqlCommandBuilder(da);

//        Console.WriteLine("1. Insert Student");
//        Console.WriteLine("2. Update Student");
//        Console.WriteLine("3. Delete Student");

//        Console.Write("Enter your choice: ");
//        int choice = Convert.ToInt32(Console.ReadLine());

//        DataTable dt = ds.Tables["Student"]!;

//        if (choice == 1)
//        {
//            // Insert Operation
//            DataRow row = dt.NewRow();

//            Console.Write("Enter Student ID: ");
//            row["Id"] = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter Student Name: ");
//            row["Name"] = Console.ReadLine();

//            Console.Write("Enter Student Age: ");
//            row["Age"] = Convert.ToInt32(Console.ReadLine());

//            Console.Write("Enter Student Course: ");
//            row["Course"] = Console.ReadLine();

//            dt.Rows.Add(row);

//            da.Update(ds, "Student");

//            Console.WriteLine("Student inserted successfully!");
//        }
//        else if (choice == 2)
//        {
//            // Update Operation
//            Console.Write("Enter Student ID to update: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            DataRow[] rows = dt.Select("Id = " + id);

//            if (rows.Length > 0)
//            {
//                Console.Write("Enter New Name: ");
//                rows[0]["Name"] = Console.ReadLine();

//                Console.Write("Enter New Age: ");
//                rows[0]["Age"] = Convert.ToInt32(Console.ReadLine());

//                da.Update(ds, "Student");

//                Console.WriteLine("Student updated successfully!");
//            }
//            else
//            {
//                Console.WriteLine("Student not found!");
//            }
//        }
//        else if (choice == 3)
//        {
//            // Delete Operation
//            Console.Write("Enter Student ID to delete: ");
//            int id = Convert.ToInt32(Console.ReadLine());

//            DataRow[] rows = dt.Select("Id = " + id);

//            if (rows.Length > 0)
//            {
//                rows[0].Delete();

//                da.Update(ds, "Student");

//                Console.WriteLine("Student deleted successfully!");
//            }
//            else
//            {
//                Console.WriteLine("Student not found!");
//            }
//        }
//        else
//        {
//            Console.WriteLine("Invalid choice!");
//        }

//        da.Dispose();
//        ds.Dispose();
//        con.Dispose();

//        Console.ReadLine();
//    }
//}
