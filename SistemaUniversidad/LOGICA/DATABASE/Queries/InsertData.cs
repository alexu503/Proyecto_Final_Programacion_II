using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using SistemaUniversidad.LOGICA;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.LOGICA.DATABASE.Queries {
    internal class InsertData {

        public void InsertToDB(string staffType, List<AcademicStaff> lstAddNewStaff) {

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            switch (staffType) {
                case "Docente":
                        break;
                case "Estudiante":
                        break;
                default:
                        break;
            }
        }
    }
}
