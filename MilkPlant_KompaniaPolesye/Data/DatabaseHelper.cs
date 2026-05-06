using Npgsql;
using System;
using System.Data;

namespace MilkPlant.Data
{
    public class DatabaseHelper
    {
        private readonly string _connectionString =
            "Host=localhost;Database=milk_plant_db;Username=postgres;Password=ваш_пароль";

        public DataTable ExecuteQuery(string query)
        {
            var table = new DataTable();

            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var adapter = new NpgsqlDataAdapter(query, connection))
                {
                    adapter.Fill(table);
                }
            }

            return table;
        }

        public bool TestConnection()
        {
            try
            {
                using (var connection = new NpgsqlConnection(_connectionString))
                {
                    connection.Open();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}