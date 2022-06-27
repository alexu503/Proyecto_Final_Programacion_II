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
            if(cmbCarreras.Text != "") {
                MySqlConnection connect = GenerateConnection.Connection();
                MySqlCommand command = new MySqlCommand();
                command.Connection = connect;
                command.CommandText = "SELECT * FROM Alumnos WHERE NombreCarrera = '"+cmbCarreras.Text+"'";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = command;
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                dgvAlumnos.DataSource = table;
                connect.Close();
            } else {
                MessageBox.Show("POR FAVOR, SELECCIONE UNA CARRERA.", "Error de filtrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Buscar alumno
        private void btnFiltrarDatos_Click(object sender, EventArgs e) {

            MySqlConnection connect = GenerateConnection.Connection();
            MySqlCommand command = new MySqlCommand();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            command.Connection = connect;

            if (cmbCarreras.Text != "" && cmbFiltro.Text != "" && txtDato.Text != "") {
                switch (cmbFiltro.Text) {
                    case "Carnet":
                        command.CommandText = "SELECT * FROM Alumnos WHERE NombreCarrera = '"+cmbCarreras.Text+"' AND Carnet = '"+txtDato.Text+"'";
                        dataAdapter.SelectCommand = command;
                        dataAdapter.Fill(table);
                        if(table.Rows.Count == 0) {
                            MessageBox.Show("ALUMNO NO ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        } else {
                            dgvAlumnos.DataSource = table;
                        }
                        break;
                    case "Nombre":
                        command.CommandText = "SELECT * FROM Alumnos WHERE NombreCarrera = '"+cmbCarreras.Text+"' AND Nombres = '"+txtDato.Text+"'";
                        dataAdapter.SelectCommand = command;
                        dataAdapter.Fill(table);
                        if (table.Rows.Count == 0) {
                            MessageBox.Show("ALUMNO NO ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        } else {
                            dgvAlumnos.DataSource = table;
                        }
                        break;
                    case "Primer apellido":
                        command.CommandText = "SELECT * FROM Alumnos WHERE NombreCarrera = '"+cmbCarreras.Text+"' AND PrimerApellido = '"+txtDato.Text+"'";
                        dataAdapter.SelectCommand = command;
                        dataAdapter.Fill(table);
                        if (table.Rows.Count == 0) {
                            MessageBox.Show("ALUMNO NO ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        } else {
                            dgvAlumnos.DataSource = table;
                        }
                        break;
                    case "Segundo apellido":
                        command.CommandText = "SELECT * FROM Alumnos WHERE NombreCarrera = '"+cmbCarreras.Text+"' AND SegundoApellido = '"+txtDato.Text+"'";
                        dataAdapter.SelectCommand = command;
                        dataAdapter.Fill(table);
                        if (table.Rows.Count == 0) {
                            MessageBox.Show("ALUMNO NO ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        } else {
                            dgvAlumnos.DataSource = table;
                        }
                        break;
                    default:
                        MessageBox.Show("DATO A FILTRAR NO SELECCIONADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
            connect.Close();
        }

        #endregion

        #region Abrir Form Editar
        private void btnModificar_Click(object sender, EventArgs e){

            int selectedRow = dgvAlumnos.CurrentCell.RowIndex;
            String[] arrayAlumno = new String[17];

            for(int x = 0; x < dgvAlumnos.Rows.Count; x++) {
                arrayAlumno[x] = dgvAlumnos.Rows[selectedRow].Cells[x].Value.ToString();
                Modificar Modificar = new Modificar();
                this.Hide();
                Modificar.modificar = this;
                Modificar.setDetalles(arrayAlumno);
            }
        }
        #endregion
    }
}
