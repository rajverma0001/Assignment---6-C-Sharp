
using System;
using Microsoft.Data.SqlClient;

class ConnectedCRUD
{
    static string cs = @"Data Source=.\SQLEXPRESS;
    Initial Catalog=CollegeDB;
    Integrated Security=True;
    TrustServerCertificate=True;";

    static void Main()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            Console.WriteLine("1. Insert Student");
            Console.WriteLine("2. Display Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");

            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                string name = Console.ReadLine()!;

                Console.Write("Enter Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Course: ");
                string course = Console.ReadLine()!;

                string query = "INSERT INTO Student VALUES (@Id,@Name,@Age,@Course)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Course", course);

                    cmd.ExecuteNonQuery();
                }

                Console.WriteLine("Student Inserted Successfully!");
            }

            else if (choice == 2)
            {
                string query = "SELECT * FROM Student";

                using (SqlCommand cmd = new SqlCommand(query, con))
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Console.WriteLine(
                            dr["Id"] + " " +
                            dr["Name"] + " " +
                            dr["Age"] + " " +
                            dr["Course"]);
                    }
                }
            }

            else if (choice == 3)
            {
                Console.Write("Enter Student ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Name: ");
                string name = Console.ReadLine()!;

                Console.Write("Enter New Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter New Course: ");
                string course = Console.ReadLine()!;

                string query = "UPDATE Student SET Name=@Name, Age=@Age, Course=@Course WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Age", age);
                    cmd.Parameters.AddWithValue("@Course", course);

                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine(rows > 0 ?
                        "Student Updated Successfully!" :
                        "Student Not Found!");
                }
            }

            else if (choice == 4)
            {
                Console.Write("Enter Student ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                string query = "DELETE FROM Student WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Id", id);

                    int rows = cmd.ExecuteNonQuery();

                    Console.WriteLine(rows > 0 ?
                        "Student Deleted Successfully!" :
                        "Student Not Found!");
                }
            }
            else
            {
                Console.WriteLine("Invalid Choice!");
            }
        }

        Console.ReadLine();
    }
}
