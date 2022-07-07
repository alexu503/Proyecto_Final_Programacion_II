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
    public partial class ModificarAlumno : Form{
        public Form modificarAlumno;
        public ModificarAlumno(){
            InitializeComponent();
        }
        private void ModificarAlumno_Load(object sender, EventArgs e){
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
        private void btnRegresar_Click(object sender, EventArgs e)
        {
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

        #region Actualizar DGV
        private void btnActualizar_Click(object sender, EventArgs e){
            //if(cmbCarreras.Text != "") {
            //    MySqlConnection connect = GenerateConnection.Connection();
            //    MySqlCommand command = new MySqlCommand();
            //    command.Connection = connect;
            //    command.CommandText = "SELECT * FROM Alumnos WHERE NombreCarrera = '"+cmbCarreras.Text+"'";
            //    MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            //    dataAdapter.SelectCommand = command;
            //    DataTable table = new DataTable();
            //    dataAdapter.Fill(table);
            //    dgvAlumnos.DataSource = table;
            //    connect.Close();
            //} else {
            //    MessageBox.Show("POR FAVOR, SELECCIONE UNA CARRERA.", "Error de filtrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
        #endregion

        #region Buscar alumno
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

        #endregion

        #region Abrir Form Editar
        private void btnModificar_Click(object sender, EventArgs e){

            //Student alumno = new Student();
            //
            //if(dgvAlumnos.Rows.Count > 0) {
            //    int selectedRow = dgvAlumnos.CurrentCell.RowIndex;
            //
            //    alumno.setNombres(dgvAlumnos.Rows[selectedRow].Cells[0].Value.ToString());
            //    alumno.setPrimerApellido(dgvAlumnos.Rows[selectedRow].Cells[1].Value.ToString());
            //    alumno.setSegundoApellido(dgvAlumnos.Rows[selectedRow].Cells[2].Value.ToString());
            //    alumno.setCarrera(dgvAlumnos.Rows[selectedRow].Cells[3].Value.ToString());
            //    alumno.setCarnet(dgvAlumnos.Rows[selectedRow].Cells[4].Value.ToString());
            //    alumno.setDocumentoIdentidad(dgvAlumnos.Rows[selectedRow].Cells[8].Value.ToString());
            //    alumno.setSexo(dgvAlumnos.Rows[selectedRow].Cells[9].Value.ToString());
            //    alumno.setDireccion(dgvAlumnos.Rows[selectedRow].Cells[10].Value.ToString());
            //    alumno.setTelefono(dgvAlumnos.Rows[selectedRow].Cells[11].Value.ToString());
            //    alumno.setCelular(dgvAlumnos.Rows[selectedRow].Cells[12].Value.ToString());
            //    alumno.setCorreo(dgvAlumnos.Rows[selectedRow].Cells[13].Value.ToString());
            //    alumno.setFechaInscripcion(dgvAlumnos.Rows[selectedRow].Cells[14].Value.ToString());
            //    alumno.setNacionalidad(dgvAlumnos.Rows[selectedRow].Cells[15].Value.ToString());
            //    alumno.setEtadoCivil(dgvAlumnos.Rows[selectedRow].Cells[16].Value.ToString());
            //    listaDetallesDeAlumnos.Add(alumno);
            //
            //    Modificar Modificar = new Modificar();
            //    this.Close();
            //    Modificar.modificar = this;
            //    Modificar.setDetalles(listaDetallesDeAlumnos);
            //    Modificar.Show();
            //} else {
            //    MessageBox.Show("NO HAY DATOS PARA MODIFICAR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        #endregion

        private void btnReturnToMainForm_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
