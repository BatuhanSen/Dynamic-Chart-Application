using System.Collections.Generic;
using BackAPI.Models;
using Npgsql;

namespace BackAPI.Services
{
    public class DBService
    {
        public string CreateConnectionString(DBInfo dbInfo)
        {
            return $"Host={dbInfo.ServerAddress};Database={dbInfo.DatabaseName};Username={dbInfo.Username};Password={dbInfo.Password}";
        }

        public List<string> GetTables(string connectionString)
        {
            var tables = new List<string>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand("SELECT table_name FROM information_schema.tables WHERE table_schema='public'", connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    tables.Add(reader.GetString(0));
                }
            }

            return tables;
        }

        public List<string> GetColumns(string connectionString, string tableName)
        {
            var columns = new List<string>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand($"SELECT column_name FROM information_schema.columns WHERE table_name = '{tableName}'", connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    columns.Add(reader.GetString(0));
                }
            }

            return columns;
        }

        public object GetData(string connectionString, string selectedTable, string selectedColumnX, string selectedColumnY)
        {
            var data = new List<object>();
            var labels = new List<string>();

            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                var command = new NpgsqlCommand($"SELECT {selectedColumnX}, {selectedColumnY} FROM {selectedTable}", connection);
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    labels.Add(reader[selectedColumnX].ToString());
                    data.Add(reader[selectedColumnY]);
                }
            }

            return new
            {
                labels = labels,
                values = data
            };
        }

    }
}
