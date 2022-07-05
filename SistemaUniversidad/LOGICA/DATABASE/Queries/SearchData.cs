using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;

namespace SistemaUniversidad.LOGICA.DATABASE.Queries {
    internal static class SearchData {

        public static SQLiteDataReader GetCareers() {

            //Get careers from DB and return it as a DataAdapter to use as a Table
            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            //Execute query:
            query.CommandText = "SELECT * FROM Careers";
            SQLiteDataReader dr = query.ExecuteReader();
            //Close DB Connection
            connection.Close();
            //Return data reader value.
            return dr;
        }
    }
}
