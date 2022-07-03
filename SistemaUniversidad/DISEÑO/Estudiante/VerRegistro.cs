using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SQLite;
using SistemaUniversidad.LOGICA;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Estudiante
{
    public partial class VerRegistro : Form
    {
        public Form buscarMateria;
        string loginID = "";
        public VerRegistro(string carnetAlumno){
            InitializeComponent();
            this.loginID = carnetAlumno;
        }
        private void BuscarAsignaturas_Load(object sender, EventArgs e){

            //string query = "Select NombreMateria FROM Materias";
            //MySqlConnection connection = GenerateConnection.Connection();
            //MySqlCommand command = new MySqlCommand(query, connection);
            //MySqlDataReader dr = command.ExecuteReader();
            //
            //try {
            //    if (dr.HasRows) {
            //        while (dr.Read()) {
            //            cmbVerMaterias.Items.Add(dr.GetString("NombreMateria"));
            //        }
            //    } else {
            //        MessageBox.Show("No hay materias disponibles");
            //        btnCargar.Enabled = false;
            //        return;
            //    }
            //} catch (Exception ex) {
            //    MessageBox.Show("Error: " + ex.Message);
            //} finally {
            //    dr.Close();
            //    connection.Close();
            //}
        }

        #region Botones Minimizar Maximizar Cerrar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Minimizar(this, sender, e);
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Maximizar(this, sender, e, btnMaximizar, btnRestaurar);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Restaurar(this, sender, e, btnRestaurar, btnMaximizar);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu.MenuEstudiante Estudiante = new Menu.MenuEstudiante(this.loginID);
            this.Close();
            Estudiante.menuEstudiante = this;
            Estudiante.Show();
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e){
            btnCerrar_Click(sender, e);
        }

        private void btnCargar_Click(object sender, EventArgs e) {

            //if(cmbVerMaterias.Text != "") {
            //
            //    MySqlConnection connection = GenerateConnection.Connection();
            //    MySqlCommand query = new MySqlCommand();
            //    query.Connection = connection;
            //
            //    try {
            //        query.CommandText = "SELECT * FROM Notas WHERE NombreMateria = '"+cmbVerMaterias.Text+"' AND CarnetAlumno = '"+this.loginID+"'";
            //        query.ExecuteNonQuery();
            //        MySqlDataAdapter da = new MySqlDataAdapter();
            //        da.SelectCommand = query;
            //        DataTable table = new DataTable();
            //        da.Fill(table);
            //        dgvAsignaturas.DataSource = table;
            //        MessageBox.Show("DATOS ACTUALIZADOS", "ATENCIÓN", MessageBoxButtons.OK);
            //    } catch (Exception ex) {
            //        MessageBox.Show("Error: " + ex.Message);
            //    } finally {
            //        connection.Close();
            //    }
            //}
        }
    }
}
