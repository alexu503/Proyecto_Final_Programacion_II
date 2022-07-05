using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SistemaUniversidad.LOGICA.DATABASE.Queries {
    internal static class UpdateData {

        public static void UpdateCareers(ref string oldCareerName, ref string newCareerName) {

            //Get careers from DB and return it as a DataReader to fill combobox
            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            //Execute query:
            query.CommandText = "UPDATE Careers SET CareerName = @NewCareerName WHERE CareerName = @OldCareerName";
            query.Parameters.Add(new SQLiteParameter("@NewCareerName", newCareerName));
            query.Parameters.Add(new SQLiteParameter("@OldCareerName", oldCareerName));
            //Close DB Connection
            connection.Close();
        }
    }
}
