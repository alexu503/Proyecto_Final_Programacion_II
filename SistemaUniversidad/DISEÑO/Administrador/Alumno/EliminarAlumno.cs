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
using SistemaUniversidad.LOGICA;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Administrador
{
    public partial class EliminarAlumno : Form
    {
        public Form eliminarAlumno;
        public EliminarAlumno(){
            InitializeComponent();
        }
        private void EliminarAlumno_Load(object sender, EventArgs e){
            cmbCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarreras.Items.Clear();
            cmbCarreras.Items.Add("Ingeniería de Sistemas Informáticos");
            cmbCarreras.Items.Add("Ingeniería Agronómica");
            cmbCarreras.Items.Add("Ingeniería Eléctrica");
            cmbCarreras.Items.Add("Ingeniería Industrial");

            //ComboBox de filtro
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.Add("Carnet");
            cmbFiltro.Items.Add("Nombres");
            cmbFiltro.Items.Add("Primer apellido");
            cmbFiltro.Items.Add("Segundo apellido");
        }

        #region Regresar - Salir
        private void btnRegresar_Click(object sender, EventArgs e){
            Menu.MenuAdmin MenuAdmin = new Menu.MenuAdmin();
            MenuAdmin.menuAdmin = this;
            this.Close();
            MenuAdmin.Show();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu.MenuAdmin MenuAdmin = new Menu.MenuAdmin();
            MenuAdmin.menuAdmin = this;
            this.Close();
            MenuAdmin.Show();
        }

        #endregion

        #region Actualizar
        private void btnActualizar_Click(object sender, EventArgs e){

            string carrera = cmbCarreras.Text;
            string campoFiltrado = cmbFiltro.Text;
            string datoFiltrado = txtDato.Text;


            //if(cmbCarreras.Text == "") {
            //    MessageBox.Show("POR FAVOR, SELECCIONE UNA CARRERA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //} 
            //else {
            //    MySqlConnection connection = GenerateConnection.Connection();
            //    MySqlCommand command = new MySqlCommand();
            //    command.Connection =  connection;
            //    command.CommandText = "SELECT * FROM Alumnos WHERE NombreCarrera = @Carrera";
            //    command.Parameters.Add(new MySqlParameter("@Carrera", cmbCarreras.Text));
            //    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            //    dataAdapter.SelectCommand = command;
            //    DataTable dataTable = new DataTable();
            //    dataAdapter.Fill(dataTable);
            //    if(dataTable.Rows.Count == 0) {
            //        MessageBox.Show("NO HAY ALUMNOS REGISTRADOS EN ESTA CARRERA");
            //    } else {
            //        dgvAlumnos.DataSource = dataTable;
            //    }
            //    connection.Close();
            //}
        }

        #endregion

        #region Eliminar Alumno
        private void btnEliminar_Click(object sender, EventArgs e){

            int rowPosition = dgvAlumnos.CurrentCell.RowIndex;

            if(cmbCarreras.Text != "") {
                //I can't delete directly database's rows positions. So, i get some unique values, consult and delete.
                string carnetAlumno = dgvAlumnos.Rows[rowPosition].Cells[4].Value.ToString();

                //MySqlConnection connection = GenerateConnection.Connection();
                //MySqlCommand command = new MySqlCommand();
                //command.Connection =  connection;
                //
                //if (carnetAlumno != "") {
                //    try {
                //        if(dgvAlumnos.Rows.Count > 0) {
                //            if (MessageBox.Show("¿Seguro que desea proceder?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                //                command.CommandText = "DELETE FROM Alumnos WHERE Carnet = '"+carnetAlumno+"'; DELETE FROM Logins WHERE Usuario = '"+carnetAlumno+"'";
                //                command.ExecuteNonQuery();
                //                MessageBox.Show("Datos eliminados satisfactoriamente");
                //                //Update table
                //                command.CommandText = "SELECT * FROM Alumnos";
                //                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                //                dataAdapter.SelectCommand = command;
                //                DataTable table = new DataTable();
                //                dataAdapter.Fill(table);
                //                dgvAlumnos.DataSource = table;
                //                connection.Close();
                //            } else {
                //                MessageBox.Show("Operación cancelada");
                //            }
                //        } else {
                //            MessageBox.Show("No hay datos para eliminar");
                //        }
                //    } catch (Exception ex) {
                //        MessageBox.Show("Ha ocurrido un error: " + ex.Message);
                //    }
                //} else {
                //    MessageBox.Show("POR FAVOR SELECCIONE UN REGISTRO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            } else {
                MessageBox.Show("POR FAVOR SELECCIONE UNA CARRERA.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void lblDatos_Click(object sender, EventArgs e) {
            if(cmbFiltro.Text == "Carnet") {
                lblDatos.Text = "Introducir carnet";
            }
            if (cmbFiltro.Text == "Nombres") {
                lblDatos.Text = "Introducir carnet";
            }
            if (cmbFiltro.Text == "Primer apellido") {
                lblDatos.Text = "Introducir carnet";
            }
            if (cmbFiltro.Text == "Segundo apellido") {
                lblDatos.Text = "Introducir carnet";
            }
        }

        private void btnFiltrarDatos_Click(object sender, EventArgs e) {
            //if (cmbCarreras.Text == "" && cmbFiltro.Text == "" || txtDato.Text == "") {
            //    MessageBox.Show("POR FAVOR, SELECCIONE LOS VALORES A FILTRAR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //} else {
            //    MySqlConnection connection = GenerateConnection.Connection();
            //    MySqlCommand command = new MySqlCommand();
            //    command.Connection =  connection;
            //    command.CommandText = "SELECT * FROM Alumnos WHERE NombreCarrera = @Carrera AND Carnet = @Carnet OR Nombres = @Nombres OR PrimerApellido = @PrimerApellido OR SegundoApellido = @SegundoApellido";
            //    command.Parameters.Add(new MySqlParameter("@Carrera", cmbCarreras.Text));
            //    command.Parameters.Add(new MySqlParameter("@Carnet", txtDato.Text));
            //    command.Parameters.Add(new MySqlParameter("@Nombres", txtDato.Text));
            //    command.Parameters.Add(new MySqlParameter("@PrimerApellido", txtDato.Text));
            //    command.Parameters.Add(new MySqlParameter("@SegundoApellido", txtDato.Text));
            //    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            //    dataAdapter.SelectCommand = command;
            //    DataTable dataTable = new DataTable();
            //    dataAdapter.Fill(dataTable);
            //    dgvAlumnos.DataSource = dataTable;
            //    connection.Close();
            //}
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
