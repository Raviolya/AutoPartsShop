using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace AutoPartsShop
{
    internal class DataBase
    {
        private void InitializeDatabase()
        {
            string dbPath = "autoparts.db";
            
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
            }

            using (var connection = new SQLiteConnection($"Data Source={dbPath};Version=3;"))
            {
                connection.Open();
                string createTablesQuery = @"
            -- Вставьте SQL-скрипт из предыдущего раздела
        ";
                using (var command = new SQLiteCommand(createTablesQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
