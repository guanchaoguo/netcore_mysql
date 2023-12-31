﻿using WebApplication1.Models;
using MySqlConnector;

namespace WebApplication1.Data
{
    public class InformationRecords
    {
        private static readonly List<Information> information = new List<Information>();
        private Information stevenInfo = new Information();
        // private MySqlConnection connection = new MySqlConnection("Server=localhost;User ID=root;Password=root;Database=ken_tutorial");

        private readonly MySqlConnection _connection;

        public InformationRecords(MySqlConnection connection)
        {
            _connection = connection;
        }

        public async Task<List<Information>> GetInformationRecords()
        {
            await _connection.OpenAsync();
            var command = new MySqlCommand("SELECT * FROM information", _connection);
            var reader = await command.ExecuteReaderAsync();
            var tableRead = await reader.ReadAsync();

            if (tableRead)
            {
                stevenInfo.Name = reader.GetString(1);
                stevenInfo.Title = reader.GetString(2);
                stevenInfo.Summary = reader.GetString(3);
            }

            information.Add(stevenInfo);

            return information;
        }
    }
}