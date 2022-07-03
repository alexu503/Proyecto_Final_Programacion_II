using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using SistemaUniversidad.LOGICA.LogicalClasses;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.LOGICA.DATABASE.Queries {
    internal static class InsertData {

        static void InsertToProfessorTable(ref List<Student> lstData) {

            string command = "INSERT INTO Professor(" +
                "FirstName," +
                "Lastname," +
                "CareerA," +
                "CareerB" +
                "DNI," +
                "Birthday," +
                "Sex," +
                "Address," +
                "Phone," +
                "MobilePhone," +
                "Nationality," +
                "CivilStatus) " +
                "VALUES(" +
                "@Firstname," +
                "@Lastname," +
                "@CareerA" +
                "@CareerB," +
                "@DNI," +
                "@Birthday," +
                "@Sex," +
                "@Address," +
                "@Phone," +
                "@MobilePhone," +
                "@Nationality," +
                "@CivilStatus)";

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            //Execute query:
            query.CommandText = command;
            foreach (AcademicStaff x in lstData) {
                query.Parameters.Add(new SQLiteParameter("@FirstName", x.FirstName));
                query.Parameters.Add(new SQLiteParameter("@Lastame", x.Lastname));
                query.Parameters.Add(new SQLiteParameter("@CareerA", x.CareerA));
                query.Parameters.Add(new SQLiteParameter("@CareerB", x.CareerB));
                query.Parameters.Add(new SQLiteParameter("@DNI", x.DNI));
                query.Parameters.Add(new SQLiteParameter("@Birthday", x.BirthDate));
                query.Parameters.Add(new SQLiteParameter("@Sex", x.Sex));
                query.Parameters.Add(new SQLiteParameter("@Address", x.Address));
                query.Parameters.Add(new SQLiteParameter("@Phone", x.Phone));
                query.Parameters.Add(new SQLiteParameter("@MobilePhone", x.MobilePhone));
                query.Parameters.Add(new SQLiteParameter("@Nationality", x.Nationality));
                query.Parameters.Add(new SQLiteParameter("@CivilStatus", x.MaritalStatus));
            }
            query.ExecuteNonQuery();
        }

        static void InsertToStudentsTable(ref List<Student> lstData) {

            string command = "INSERT INTO Student(" +
                "FirstName," +
                "Lastname," +
                "Career," +
                "DNI," +
                "Birthday," +
                "Sex," +
                "Address," +
                "Phone," +
                "MobilePhone," +
                "Nationality," +
                "CivilStatus) " +
                "VALUES(" +
                "@Firstname," +
                "@Lastname," +
                "@Career," +
                "@DNI," +
                "@Birthday," +
                "@Sex," +
                "@Address," +
                "@Phone," +
                "@MobilePhone," +
                "@Nationality," +
                "@CivilStatus)";

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            //Execute query:
            query.CommandText = command;
            foreach (AcademicStaff x in lstData) {
                query.Parameters.Add(new SQLiteParameter("@FirstName", x.FirstName));
                query.Parameters.Add(new SQLiteParameter("@Lastame", x.Lastname));
                query.Parameters.Add(new SQLiteParameter("@Career", x.CareerA));
                query.Parameters.Add(new SQLiteParameter("@DNI", x.DNI));
                query.Parameters.Add(new SQLiteParameter("@Birthday", x.BirthDate));
                query.Parameters.Add(new SQLiteParameter("@Sex", x.Sex));
                query.Parameters.Add(new SQLiteParameter("@Address", x.Address));
                query.Parameters.Add(new SQLiteParameter("@Phone", x.Phone));
                query.Parameters.Add(new SQLiteParameter("@MobilePhone", x.MobilePhone));
                query.Parameters.Add(new SQLiteParameter("@Nationality", x.Nationality));
                query.Parameters.Add(new SQLiteParameter("@CivilStatus", x.MaritalStatus));
            }
            query.ExecuteNonQuery();
        }

        static void InsertToLogins(ref List<Student> lstData) {
            string command = "INSERT INTO Logins(" +
                "Username," +
                "Password," +
                "Rol) VALUES(" +
                "@Username," +
                "@Password," +
                "@Rol)";

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            //Execute query:
            query.CommandText = command;
            foreach(Student l in lstData) {
                //query.Parameters.Add(new SQLiteParameter("@Username", l.Username));
                //query.Parameters.Add(new SQLiteParameter("@Password", l.Password));
                //query.Parameters.Add(new SQLiteParameter("@Rol", l.Rol));
            }
            query.ExecuteNonQuery();
        }

        public static void InsertToDB(string staffType, ref List<Student> lstAddNewStaff) {

            switch (staffType) {
                case "Docente":
                    InsertToProfessorTable(ref lstAddNewStaff);
                    break;
                case "Estudiante":
                    InsertToStudentsTable(ref lstAddNewStaff);
                    break;
                case "Estudiante (en prácticas)":
                    InsertToStudentsTable(ref lstAddNewStaff);
                    break;
                default:
                    break;
            }
        }
    }
}
