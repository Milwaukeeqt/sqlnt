using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace SQLnTABLES
{
    public class Person
    {
        public string Name{ get; set; }

        public string Surname { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }

        public void ExecuteSql(SqlConnection con)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Person (Name, Surname, Age, Gender) VALUES (@Name, @Surname, @Age, @Gender)";
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Surname", Surname);
                cmd.Parameters.AddWithValue("@Age", Age);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}