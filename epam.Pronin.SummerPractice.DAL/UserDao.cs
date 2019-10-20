using epam.Pronin.SummerPractice.Entities;
using epam.Pronin.SummerPractice.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace epam.Pronin.SummerPractice.DAL
{
    public class UserDao : IUserDao
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public int Authorizate(string log, string pass)
        {
            int id = -1;
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Authorizate";
                cmd.Parameters.AddWithValue(@"Login_User", log);
                cmd.Parameters.AddWithValue(@"Password_User", pass);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = (int)reader["Id_User"];
                }
            }
            return id;
        }

        public void Registrate(User value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Registrate";
                cmd.Parameters.AddWithValue(@"Name_User", value.Name_user);
                cmd.Parameters.AddWithValue(@"Login_User", value.Login);
                cmd.Parameters.AddWithValue(@"Password_User", value.Password);
                var id = new SqlParameter
                {
                    DbType = DbType.Int32,
                    ParameterName = "@Id_user",
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<User> GetUser(int id)
        {
            List<User> users = new List<User>();

            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetUser";
                cmd.Parameters.AddWithValue(@"Id_User", id);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    users.Add(new User
                    {
                        Id_user = (int)reader["Id_User"],
                        Name_user = (string)reader["NameUser"],
                    });
                }
            }
            return users;
        }

        public void DeleteUser(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteUser";
                cmd.Parameters.AddWithValue(@"Id_User", id);
                connection.Open();
                var reader = cmd.ExecuteReader();
            }
        }


    }
}
