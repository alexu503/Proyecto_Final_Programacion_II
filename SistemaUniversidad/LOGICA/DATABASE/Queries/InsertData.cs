using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SistemaUniversidad.LOGICA.LogicalClasses;

namespace SistemaUniversidad.LOGICA.DATABASE.Queries {
    internal static class InsertData {

        #region ProfessorTable
        public static void InsertToProfessorTable(ref List<Proffessor> lstData) {

            Random r = new Random();
            int idRandomCode = r.Next(1000, 9999);
            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            
            //Execute query:
            query.CommandText = "INSERT INTO Professor(" +
                "ProfessorID," +
                "Name," +
                "FirstSurname," +
                "SecondSurname," +
                "CareerA," +
                "CareerB) " +
                "VALUES(" +
                "@ProfessorID," +
                "@Name," +
                "@FirstSurname," +
                "@SecondSurname," +
                "@CareerA," +
                "@CareerB)";
            foreach (AcademicStaff x in lstData) {

                string username = x.FirstSurname.ToLower() + "." + x.SecondSurname.ToLower() + DateTime.Today.Year.ToString().Substring(2, 2) + idRandomCode.ToString().Substring(2, 2);

                query.Parameters.Add(new SQLiteParameter("@ProfessorID", username));
                query.Parameters.Add(new SQLiteParameter("@Name", x.Name));
                query.Parameters.Add(new SQLiteParameter("@FirstSurname", x.FirstSurname));
                query.Parameters.Add(new SQLiteParameter("@SecondSurname", x.SecondSurname));
                query.Parameters.Add(new SQLiteParameter("@CareerA", x.CareerA));
                query.Parameters.Add(new SQLiteParameter("@CareerB", x.CareerB));

                InsertToLogins("Docente", username);

            }
            query.ExecuteNonQuery();
            connection.Close();
        }
        #endregion

        #region StudentTable
        public static void InsertToStudentsTable(ref List<Student> lstData) {

            Random r = new Random();
            int idRandomCode = r.Next(1000, 9999);
            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            //Execute query:
            query.CommandText = "INSERT INTO Student(" +
                "FirstName," +
                "Lastname," +
                "Career," +
                "ID," +
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
                "@ID," +
                "@DNI," +
                "@Birthday," +
                "@Sex," +
                "@Address," +
                "@Phone," +
                "@MobilePhone," +
                "@Nationality," +
                "@CivilStatus)";
            foreach (AcademicStaff x in lstData) {
                string username = x.FirstSurname.Substring(0, 1).ToUpper() + x.SecondSurname.Substring(0, 1) + DateTime.Today.Year.ToString().Substring(2, 2) + idRandomCode.ToString();

                query.Parameters.Add(new SQLiteParameter("@FirstName", x.Name));
                query.Parameters.Add(new SQLiteParameter("@Lastame", x.FirstSurname));
                query.Parameters.Add(new SQLiteParameter("@Lastame", x.SecondSurname));
                query.Parameters.Add(new SQLiteParameter("@Career", x.CareerA));
                query.Parameters.Add(new SQLiteParameter("@ID", username));
                query.Parameters.Add(new SQLiteParameter("@DNI", x.DNI));
                query.Parameters.Add(new SQLiteParameter("@Birthday", x.BirthDate));
                query.Parameters.Add(new SQLiteParameter("@Sex", x.Sex));
                query.Parameters.Add(new SQLiteParameter("@Address", x.Address));
                query.Parameters.Add(new SQLiteParameter("@Phone", x.Phone));
                query.Parameters.Add(new SQLiteParameter("@MobilePhone", x.MobilePhone));
                query.Parameters.Add(new SQLiteParameter("@Nationality", x.Nationality));
                query.Parameters.Add(new SQLiteParameter("@CivilStatus", x.MaritalStatus));

                InsertToLogins("Estudiante", username);

            }
            query.ExecuteNonQuery();
            connection.Close();
        }
        #endregion

        #region LoginTable
        static void InsertToLogins(string staffType, string username) {

            Random r = new Random();
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

            query.Parameters.Add(new SQLiteParameter("@Username", username));
            query.Parameters.Add(new SQLiteParameter("@Password", password));
            query.Parameters.Add(new SQLiteParameter("@Rol", staffType));
            query.ExecuteNonQuery();
            connection.Close();
        }
        #endregion

        #region CareersTable
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
        #endregion

        #region SubjectsTable
        public static void AddNewSubject(ref string career, ref string newSubject, ref string designedProfessor) {

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            //Execute query:
            query.CommandText = "INSERT INTO Subjects(" +
                "Career, Subject, ProfessorID) " +
                "VALUES(@CareerName, @SubjectName, @ProfessorID)";
            query.Parameters.Add(new SQLiteParameter("@CareerName", career));
            query.Parameters.Add(new SQLiteParameter("@SubjectName", newSubject));
            query.Parameters.Add(new SQLiteParameter("@ProfessorID", designedProfessor));
            query.ExecuteNonQuery();
            connection.Close();
        }
        #endregion
    }
}
