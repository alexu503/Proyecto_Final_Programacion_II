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
        public EliminarAlumno()
        {
            InitializeComponent();
        }
        private void EliminarAlumno_Load(object sender, EventArgs e)
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

        #region Regresar - Salir
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu.MenuAdmin MenuAdmin = new Menu.MenuAdmin();
            MenuAdmin.menuAdmin = this;
            MenuAdmin.setAlumSistemas(listaRsistemas);
            MenuAdmin.setAlumAgronomia(listaRagronomia);
            MenuAdmin.setAlumElectrica(listaRelectrica);
            MenuAdmin.setAlumIndustrial(listaRindustrial);
            this.Close();
            MenuAdmin.Show();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu.MenuAdmin MenuAdmin = new Menu.MenuAdmin();
            MenuAdmin.menuAdmin = this;
            MenuAdmin.setAlumSistemas(listaRsistemas);
            MenuAdmin.setAlumAgronomia(listaRagronomia);
            MenuAdmin.setAlumElectrica(listaRelectrica);
            MenuAdmin.setAlumIndustrial(listaRindustrial);
            this.Close();
            MenuAdmin.Show();
        }

        #endregion

        #region Actualizar
        private void btnActualizar_Click(object sender, EventArgs e){

            if (cmbCarreras.Text != ""){
                MySqlConnection connection = GenerateConnection.Connection();
                MySqlCommand command = new MySqlCommand();
                command.Connection =  connection;
                command.CommandText = "SELECT * FROM Alumnos WHERE NombreCarrera = @Value";
                command.Parameters.Add(new MySqlParameter("@Value", cmbCarreras.Text));
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();
                dataAdapter.SelectCommand = command;
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dgvAlumnos.DataSource = dataTable;
                connection.Close();
            }
            else{
                MessageBox.Show("POR FAVOR, SELECCIONE UNA CARRERA.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private bool VerificarCampoVacio()
        {
            foreach (Control control in groupBoxFiltro.Controls)
            {
                if (control is TextBox && control.Text == "")
                {
                    MessageBox.Show("POR FAVOR INSERTE EL DATO A FILTRAR.", "Error de filtrado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Buscar Alumno
        private void Buscar(string dato, int carrera, int filtro)
        {
            bool encontrado = false;//verifica si el alumno fue encontrado
            if (carrera == 1)//Carrera -> Sistemas
            {
                if (filtro == 1)//Filtro -> Carnet
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRsistemas)
                    {
                        if (dato == item.getCarnet())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 2)//Filtro -> Nombres
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRsistemas)
                    {
                        if (dato == item.getNombres())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 3)//Filtro -> Primer Apellido
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRsistemas)
                    {
                        if (dato == item.getPrimerApellido())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 4)//Filtro -> Segundo Apellido
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRsistemas)
                    {
                        if (dato == item.getSegundoApellido())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            else if (carrera == 2)//Carrera -> Agronomia
            {
                if (filtro == 1)//Filtro -> Carnet
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRagronomia)
                    {
                        if (dato == item.getCarnet())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 2)//Filtro -> Nombres
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRagronomia)
                    {
                        if (dato == item.getNombres())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 3)//Filtro -> Primer Apellido
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRagronomia)
                    {
                        if (dato == item.getPrimerApellido())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 4)//Filtro -> Segundo Apellido
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRagronomia)
                    {
                        if (dato == item.getSegundoApellido())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else if (carrera == 3)//Carrera -> Eléctrica
            {
                if (filtro == 1)//Filtro -> Carnet
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRelectrica)
                    {
                        if (dato == item.getCarnet())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 2)//Filtro -> Nombres
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRelectrica)
                    {
                        if (dato == item.getNombres())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 3)//Filtro -> Primer Apellido
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRelectrica)
                    {
                        if (dato == item.getPrimerApellido())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 4)//Filtro -> Segundo Apellido
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRelectrica)
                    {
                        if (dato == item.getSegundoApellido())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else if (carrera == 4)//Carrera -> Industrial
            {
                if (filtro == 1)//Filtro -> Carnet
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRindustrial)
                    {
                        if (dato == item.getCarnet())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 2)//Filtro -> Nombres
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRindustrial)
                    {
                        if (dato == item.getNombres())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 3)//Filtro -> Primer Apellido
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRindustrial)
                    {
                        if (dato == item.getPrimerApellido())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (filtro == 4)//Filtro -> Segundo Apellido
                {
                    AgregarColumnasDTGV();
                    foreach (Alumno item in listaRindustrial)
                    {
                        if (dato == item.getSegundoApellido())
                        {
                            string[] registro = {item.getNombres(),item.getPrimerApellido(),item.getSegundoApellido(),
                            item.getCarnet(),item.getCarrera(),item.getPasswrd(),item.getMatricula().ToString(),item.getFechaNacimiento(),
                            item.getDocumentoIdentidad(),item.getSexo(),item.getDireccion(),item.getTelefono(),item.getCelular(),
                            item.getCorreo(),item.getFechaInscripcion(),item.getNacionalidad(),item.getEstadoCivil()};
                            dgvAlumnos.Rows.Add(registro);
                            encontrado = true;
                        }
                    }
                    if (encontrado != true)
                    {
                        LimpiarDataGrid();
                        MessageBox.Show("LO SENTIMOS, EL ALUMNO NO FUE ENCONTRADO.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }

        }
        #endregion

        #region Eliminar Alumno
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice;
            if (eliminar != -1)
            {
                if (cmbCarreras.Text == "Ingeniería de Sistemas Informáticos")
                {
                    indice = ElementoEliminar(1);
                    listaRsistemas.RemoveAt(indice);
                    ActualizarDataSistemas();
                }
                else if (cmbCarreras.Text == "Ingeniería Agronómica")
                {
                    indice = ElementoEliminar(2);
                    listaRagronomia.RemoveAt(indice);
                    ActualizarDataAgronomia();
                }
                else if (cmbCarreras.Text == "Ingeniería Eléctrica")
                {
                    indice = ElementoEliminar(3);
                    listaRelectrica.RemoveAt(indice);
                    ActualizarDataElectrica();
                }
                else if (cmbCarreras.Text == "Ingeniería Industrial")
                {
                    indice = ElementoEliminar(4);
                    listaRindustrial.RemoveAt(indice);
                    ActualizarDataIndustrial();
                }
            }
            else
            {
                MessageBox.Show("POR FAVOR SELECCIONE UN REGISTRO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaSeleccionada = dgvAlumnos.SelectedRows[0];
            carnet = filaSeleccionada.Cells[3].Value.ToString();
            eliminar = dgvAlumnos.Rows.IndexOf(filaSeleccionada);
        }
        private int ElementoEliminar(int carrera)
        {
            int indice=0,elim = 0;
            if (carrera == 1)//Carrera -> Sitemas
            {
                if (carnet != "")
                {
                    foreach (Alumno item in listaRsistemas)
                    {
                        if (item.getCarnet() == carnet)
                        {
                            elim = indice;
                        }
                        indice++;
                    }

                }
                else
                {
                    MessageBox.Show("POR FAVOR SELECCIONE UN REGISTRO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (carrera == 2)//Carrera -> Agronomia
            {
                if (carnet != "")
                {
                    foreach (Alumno item in listaRagronomia)
                    {
                        if (item.getCarnet() == carnet)
                        {
                            elim = indice;
                        }
                        indice++;
                    }
                }
                else
                {
                    MessageBox.Show("POR FAVOR SELECCIONE UN REGISTRO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (carrera == 3)//Carrera -> Electrica
            {
                if (carnet != "")
                {
                    foreach (Alumno item in listaRelectrica)
                    {
                        if (item.getCarnet() == carnet)
                        {
                            elim = indice;
                        }
                        indice++;
                    }
                }
                else
                {
                    MessageBox.Show("POR FAVOR SELECCIONE UN REGISTRO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (carrera == 4)//Carrera -> Industrial
            {
                if (carnet != "")
                {
                    foreach (Alumno item in listaRindustrial)
                    {
                        if (item.getCarnet() == carnet)
                        {
                            elim = indice;
                        }
                        indice++;
                    }
                }
                else
                {
                    MessageBox.Show("POR FAVOR SELECCIONE UN REGISTRO.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return elim;
        }
        #endregion
    }
}
