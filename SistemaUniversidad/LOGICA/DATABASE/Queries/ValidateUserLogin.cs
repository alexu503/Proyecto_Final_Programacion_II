using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SistemaUniversidad.LOGICA.DATABASE.Queries {
    internal class ValidateUserLogin {

        public static string CorrectCredentials(string usernameInput, string passInput) {

            string correctDataFor = "";
            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;

            query.CommandText = "SELECT Username, Password, Rol FROM Logins WHERE Username = @Username AND Password = @Password";
            query.Parameters.Add(new SQLiteParameter("@Username", usernameInput));
            query.Parameters.Add(new SQLiteParameter("@Password", passInput));
            query.ExecuteNonQuery();
            SQLiteDataReader dr = query.ExecuteReader();

            while (dr.Read()) {

                string username = dr["Username"].ToString();
                string password = dr["Password"].ToString();
                string rol = dr["Rol"].ToString();

                if (username == usernameInput && password == passInput) {
                    switch (rol) {
                        case "Administrador":
                            correctDataFor = "Administrador";
                            break;
                        case "Docente":
                            correctDataFor = "Docente";
                            break;
                        case "Estudiante":
                            correctDataFor = "Estudiante";
                            break;
                        default:
                            correctDataFor = "No one";
                            break;
                    }
                } else {
                    correctDataFor = "No one";
                }
            }
            connection.Close();
            return correctDataFor;
        }

    }
}
