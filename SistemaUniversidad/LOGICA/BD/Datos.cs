using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace SistemaUniversidad.LOGICA.BD
{
    public class Datos
    {
        static string database = Application.StartupPath + "database.db";
        public SqliteConnection conect;
        public Datos()
        {
            CrearDB();//Crea el archivo de base de datos
            conect = new SqliteConnection("Data Source="+database);//Define el origen de datos de la conexión
        }
        private void CrearDB()
        {
            if (!File.Exists(database))//Identifica si la base de datos no existe
            {
                var archivo = File.Create(database);//crea el archivo
                archivo.Close();
            }
        }
        private void ConectarDB()
        {
            if (conect.State == ConnectionState.Closed)//Si la conexión de la base de datos está cerrada
            {
                conect.Open();//Abre la conexión
            }
        }
        private void CrearTabla()
        {
            ConectarDB();
            string cadena = "Create Table If Not Exists Alumnos(Carnet Text not null Primary Key,"+
                "Nombres Text Not Null, PApellido Text Not Null, SApellido Text Not Null, Carrera Text Not Null," +
                "Password Text Not Null, Matricula Integer Not Null, FechaNacimiento)";
        }
    }
}
