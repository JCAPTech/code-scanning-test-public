using System;
using System.Data.SqlClient;

class Program
{
    static void Main(string[] args)
    {
        string userInput = args[0];
        string query = "SELECT * FROM Users WHERE Name = '" + userInput + "'";  // BAD

        using (SqlConnection conn = new SqlConnection("connection-string"))
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteReader();
        }
    }
}
