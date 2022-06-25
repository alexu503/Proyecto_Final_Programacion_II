using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
    }
}
