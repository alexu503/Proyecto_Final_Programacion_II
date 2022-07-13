using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SistemaUniversidad.LOGICA.LogicalClasses;

namespace SistemaUniversidad.LOGICA.DATABASE.Queries {
    internal static class InsertData {

        static void InsertToProfessorTable(ref List<Student> lstData) {

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            //Execute query:
            query.CommandText = "INSERT INTO Professor(" +
                "FirstName," +
                "FirstSurname," +
                "SecondSurname," +
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
            foreach (AcademicStaff x in lstData) {
                query.Parameters.Add(new SQLiteParameter("@FirstName", x.Name));
                query.Parameters.Add(new SQLiteParameter("@FirstSurname", x.FirstSurname));
                query.Parameters.Add(new SQLiteParameter("@SecondSurname", x.SecondSurname));
                query.Parameters.Add(new SQLiteParameter("@Lastame", x.FirstSurname));
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
            connection.Close();
        }

        static void InsertToStudentsTable(ref List<Student> lstData) {

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            //Execute query:
            query.CommandText = "INSERT INTO Student(" +
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
            foreach (AcademicStaff x in lstData) {
                query.Parameters.Add(new SQLiteParameter("@FirstName", x.Name));
                query.Parameters.Add(new SQLiteParameter("@Lastame", x.FirstSurname));
                query.Parameters.Add(new SQLiteParameter("@Lastame", x.SecondSurname));
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
            connection.Close();
        }

        static void InsertToLogins(string staffType, ref List<Student> lstData) {

            Random r = new Random();
            //DateTime dt = new DateTime();
            int idRandomCode = r.Next(1000, 9999);
            string username = "";
            string password = DateTime.Today.Year.ToString().Substring(2, 2) + r.Next(100000, 999999).ToString();

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            //Execute query:
            query.CommandText = "INSERT INTO Logins(" +
                "Username," +
                "Password," +
                "Rol) VALUES(" +
                "@Username," +
                "@Password," +
                "@Rol)";
            foreach (Student l in lstData) {
                username = l.FirstSurname.Substring(0, 1).ToUpper() + l.SecondSurname.Substring(0, 1) + DateTime.Today.Year.ToString().Substring(2, 2) + idRandomCode.ToString();
            }
            query.Parameters.Add(new SQLiteParameter("@Username", username));
            query.Parameters.Add(new SQLiteParameter("@Password", password));
            query.Parameters.Add(new SQLiteParameter("@Rol", staffType));
            query.ExecuteNonQuery();
            connection.Close();
        }

        public static void AddNewCareer(string newCareer) {

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            //Execute query:
            query.CommandText = "INSERT INTO Careers(CareerName) VALUES(@CareerName)";
            query.Parameters.Add(new SQLiteParameter("@CareerName", newCareer));
            query.ExecuteNonQuery();
            connection.Close();
        }

        //Modify

        public static void AddNewSubject(ref string career, ref string newSubject, ref string designedProfessor) {

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            //Execute query:
            query.CommandText = "INSERT INTO Subjects(" +
                "Carrer, Subject, ProfessorID) " +
                "VALUES(@CareerName, @SubjectName, @ProfessorID)";
            query.Parameters.Add(new SQLiteParameter("@CareerName", career));
            query.Parameters.Add(new SQLiteParameter("@SubjectName", newSubject));
            query.Parameters.Add(new SQLiteParameter("@ProfessorID", designedProfessor));
            query.ExecuteNonQuery();
            connection.Close();
        }

        public static void InsertToDB(string staffType, ref List<Student> lstAddNewStaff) {

            switch (staffType) {
                case "Docente":
                    InsertToProfessorTable(ref lstAddNewStaff);
                    InsertToLogins("Docente", ref lstAddNewStaff);
                    break;
                case "Estudiante":
                    InsertToStudentsTable(ref lstAddNewStaff);
                    InsertToLogins("Estudiante", ref lstAddNewStaff);
                    break;
                case "Estudiante en prácticas":
                    InsertToStudentsTable(ref lstAddNewStaff);
                    InsertToLogins("Estudiante en prácticas", ref lstAddNewStaff);
                    break;
                default:
                    break;
            }
        }
    }
}
