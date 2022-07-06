using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.LOGICA.DATABASE.Queries {
    internal static class DeleteData {

        public static void DeleteCareer(ref string carrerToDelete) {
            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            query.CommandText = "DELETE FROM Careers WHERE CareerName = @Career";
            query.Parameters.Add(new SQLiteParameter("@Career", carrerToDelete));
            query.ExecuteNonQuery();
            connection.Close();
        }
    }
}
