using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SistemaUniversidad.LOGICA.DATABASE {
    internal class GenerateConnection {

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
