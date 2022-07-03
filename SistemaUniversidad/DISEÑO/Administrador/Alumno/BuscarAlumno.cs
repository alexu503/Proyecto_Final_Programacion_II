using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA;
using MySql.Data.MySqlClient;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Administrador
{
    public partial class BuscarAlumno : Form
    {
        public Form buscarAlumno;
        public BuscarAlumno()
        {
            InitializeComponent();
        }
        private void BuscarAlumno_Load(object sender, EventArgs e)
        {
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

        #region Regresar
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu.MenuAdmin MenuAdmin = new Menu.MenuAdmin();
            MenuAdmin.menuAdmin = this;
            //MenuAdmin.setAlumSistemas(listaRsistemas);
            //MenuAdmin.setAlumAgronomia(listaRagronomia);
            //MenuAdmin.setAlumElectrica(listaRelectrica);
            //MenuAdmin.setAlumIndustrial(listaRindustrial);
            this.Close();
            MenuAdmin.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu.MenuAdmin MenuAdmin = new Menu.MenuAdmin();
            MenuAdmin.menuAdmin = this;
            //MenuAdmin.setAlumSistemas(listaRsistemas);
            //MenuAdmin.setAlumAgronomia(listaRagronomia);
            //MenuAdmin.setAlumElectrica(listaRelectrica);
            //MenuAdmin.setAlumIndustrial(listaRindustrial);
            this.Close();
            MenuAdmin.Show();
        }
        #endregion

        #region Actualizad Datos
        private void btnActualizar_Click(object sender, EventArgs e){

            //if (cmbCarreras.Text == "") {
            //    MessageBox.Show("POR FAVOR, SELECCIONE UNA CARRERA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //} else {
            //    MySqlConnection connection = GenerateConnection.Connection();
            //    MySqlCommand command = new MySqlCommand();
            //    command.Connection =  connection;
            //    command.CommandText = "SELECT * FROM Alumnos WHERE NombreCarrera = @Carrera";
            //    command.Parameters.Add(new MySqlParameter("@Carrera", cmbCarreras.Text));
            //    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            //    dataAdapter.SelectCommand = command;
            //    DataTable dataTable = new DataTable();
            //    dataAdapter.Fill(dataTable);
            //    if (dataTable.Rows.Count == 0) {
            //        MessageBox.Show("NO HAY ALUMNOS REGISTRADOS EN ESTA CARRERA");
            //    } else {
            //        dgvAlumnos.DataSource = dataTable;
            //    }
            //    connection.Close();
            //}
        }
        #endregion

        #region Buscar Alumno
        //
        #endregion

        private void btnLoadFilters_Click(object sender, EventArgs e) {
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
    }
}
