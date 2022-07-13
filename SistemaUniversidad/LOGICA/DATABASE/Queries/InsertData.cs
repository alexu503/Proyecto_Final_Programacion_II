using System;
using System.Collections.Generic;
using System.Data.SQLite;
using SistemaUniversidad.LOGICA.LogicalClasses;

namespace SistemaUniversidad.LOGICA.DATABASE.Queries {
    internal static class InsertData {

        #region ProfessorTable
        public static void InsertToProfessorTable(ref List<Proffessor> lstData) {

            SQLiteConnection connection = GenerateConnection.GetConnection();
            SQLiteCommand query = new SQLiteCommand();
            query.Connection = connection;
            //Execute query:
            query.CommandText = "INSERT INTO Professor(" +
                "Name," +
                "FirstSurname," +
                "SecondSurname," +
                "CareerA," +
                "CareerB) " +
                "VALUES(" +
                "@Name," +
                "@FirstSurname," +
                "@SecondSurname," +
                "@CareerA," +
                "@CareerB)";
            foreach (AcademicStaff x in lstData) {
                query.Parameters.Add(new SQLiteParameter("@Name", x.Name));
                query.Parameters.Add(new SQLiteParameter("@FirstSurname", x.FirstSurname));
                query.Parameters.Add(new SQLiteParameter("@SecondSurname", x.SecondSurname));
                query.Parameters.Add(new SQLiteParameter("@CareerA", x.CareerA));
                query.Parameters.Add(new SQLiteParameter("@CareerB", x.CareerB));

                InsertToLogins("Docente", x.Name, x.FirstSurname, x.SecondSurname);

            }
            query.ExecuteNonQuery();
            connection.Close();
        }
        #endregion

        #region StudentTable
        public static void InsertToStudentsTable(ref List<Student> lstData) {

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

                InsertToLogins("Estudiante", x.Name, x.FirstSurname, x.SecondSurname);

            }
            query.ExecuteNonQuery();
            connection.Close();
        }
        #endregion

        #region LoginTable
        static void InsertToLogins(string staffType, string name, string firstSurname, string secondSurname) {

            Random r = new Random();
            //DateTime dt = new DateTime();
            int idRandomCode = r.Next(1000, 9999);
            string username = "";
            string password = DateTime.Today.Year.ToString().Substring(2, 2) + r.Next(100000, 999999).ToString();
            
            if(staffType == "Estudiante") {
                username = firstSurname.Substring(0, 1).ToUpper() + secondSurname.Substring(0, 1) + DateTime.Today.Year.ToString().Substring(2, 2) + idRandomCode.ToString();
            } else {
                username = name.ToLower() + firstSurname.ToLower() + DateTime.Today.Year.ToString().Substring(2, 2) + idRandomCode.ToString().Substring(2, 2);
            }

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
                "Carrer, Subject, ProfessorID) " +
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
