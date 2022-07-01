using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.SQLite;

namespace SistemaUniversidad.LOGICA.DATABASE {
    internal class GenerateConnection {

        public static MySqlConnection Connection() {

            string connectionString = "SERVER=sql5.freemysqlhosting.net;PORT=3306;DATABASE=sql5501274; UID=sql5501274;PASSWORD=vrecNc1k4u;";

            MySqlConnection connection = new MySqlConnection(connectionString);

            try {
                connection.Open();
                Console.WriteLine("Conexión exitosa");
            } catch(Exception e) {
                Console.WriteLine("Error: " + e.Message);
            }
            return connection;
        }

        public static SQLiteConnection GetConnection() {

            SQLiteConnection connection = new SQLiteConnection("Data Source = ..\\..\\DB\\SistemaUniversitario.sqlite; Version = 3; New = True; Compress = True");

            try {
                connection.Open();
                Console.WriteLine("Conexión exitosa");
            } catch(Exception e) {
                Console.WriteLine("Error en conexión: " + e.Message);
            }

            return connection;
        }

    }
}
