using epam.Pronin.SummerPractice.DAL.Interface;
using epam.Pronin.SummerPractice.Entities;
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
    public class LotDao :ILotDao
    {
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;

        public void Add(Lot value)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                connection.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddLot";
                cmd.Parameters.AddWithValue(@"Name_Lot", value.Name_Lot);
                cmd.ExecuteNonQuery();
            }
        }
        public IEnumerable<Lot> GetAll()
        {
            List<Lot> lots = new List<Lot>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetAll";
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lots.Add(new Lot
                    {
                        Id_lot = (int)reader["Id_Lot"],
                        Name_Lot = (string)reader["Name_Lot"],
                    });
                }
            }
            return lots;
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteLot";
                cmd.Parameters.AddWithValue(@"Id_Lot", id);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Lot GetById(int id)
        {
            Lot lot = new Lot();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetById";
                cmd.Parameters.AddWithValue(@"Id_Lot", id);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lot.Id_lot = (int)reader["Id_Lot"];
                    lot.Name_Lot = (string)reader["Name_Lot"];
                }
            }
            return lot;
        }

        public Lot GetByName(string name)
        {
            Lot lot = new Lot();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetByName";
                cmd.Parameters.AddWithValue(@"Name_Lot", name);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lot.Id_lot = (int)reader["Id_Lot"];
                    lot.Name_Lot = (string)reader["Name_Lot"];
                }
            }
            return lot;
        }

        public void AddUserLot(int id_user, int id_lot)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AddUserLot";
                cmd.Parameters.AddWithValue(@"UserId", id_user);
                cmd.Parameters.AddWithValue(@"LotId", id_lot);
                connection.Open();
                var reader = cmd.ExecuteReader();
            }
        }

        public void DeleteUserLot(int id_user, int id_lot)
        {

            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "DeleteUserLot";
                cmd.Parameters.AddWithValue(@"UserId", id_user);
                cmd.Parameters.AddWithValue(@"LotId", id_lot);
                connection.Open();
                var reader = cmd.ExecuteReader();
            }

        }

        public IEnumerable<Lot> GetUserLot(int id_user)
        {

            List<Lot> lots = new List<Lot>();
            using (var connection = new SqlConnection(_connectionString))
            {
                var cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetUserLot";
                cmd.Parameters.AddWithValue(@"UserId", id_user);
                connection.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    lots.Add(new Lot
                    {
                        Id_lot = (int)reader["Id_Lot"],
                        Name_Lot = (string)reader["Name_Lot"]
                    });
                }
            }
            return lots;
        }

    }
}
