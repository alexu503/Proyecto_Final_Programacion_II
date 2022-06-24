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

        #region Actualizad Datos
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (cmbCarreras.Text != "")
            {
                if (cmbCarreras.Text == "Ingeniería de Sistemas Informáticos")//Carrera 1
                {
                    if (cboxFiltros.Checked != true)//Sino se está utilixando filtros
                    {
                        ActualizarDataSistemas();
                    }
                    else
                    {
                        if (!VerificarCampoVacio())
                        {
                            //Filtrar 1
                            if (cmbFiltro.Text == "Carnet")//Filtro 1
                            {
                                Buscar(txtDato.Text, 1, 1);
                            }
                            else if (cmbFiltro.Text == "Nombres")//Filtro 2
                            {
                                Buscar(txtDato.Text, 1, 2);
                            }
                            else if (cmbFiltro.Text == "Primer apellido")//Filtro 3
                            {
                                Buscar(txtDato.Text, 1, 3);
                            }
                            else if (cmbFiltro.Text == "Segundo apellido")//Filtro 4
                            {
                                Buscar(txtDato.Text, 1, 4);
                            }
                            else
                            {
                                MessageBox.Show("POR FAVOR, SELECCIONE EL DATO A FILTRAR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    } 
                }
                else if (cmbCarreras.Text == "Ingeniería Agronómica")//Carrera 2
                {
                    if (cboxFiltros.Checked != true)//Sino se está utilixando filtros
                    {
                        ActualizarDataAgronomia();
                    }
                    else
                    {
                        if (!VerificarCampoVacio())
                        {
                            //Filtrar 2
                            if (cmbFiltro.Text == "Carnet")//Filtro 1
                            {
                                Buscar(txtDato.Text, 2, 1);
                            }
                            else if (cmbFiltro.Text == "Nombres")//Filtro 2
                            {
                                Buscar(txtDato.Text, 2, 2);
                            }
                            else if (cmbFiltro.Text == "Primer apellido")//Filtro 3
                            {
                                Buscar(txtDato.Text, 2, 3);
                            }
                            else if (cmbFiltro.Text == "Segundo apellido")//Filtro 4
                            {
                                Buscar(txtDato.Text, 2, 4);
                            }
                            else
                            {
                                MessageBox.Show("POR FAVOR, SELECCIONE EL DATO A FILTRAR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }  
                }
                else if (cmbCarreras.Text == "Ingeniería Eléctrica")//Carrera 3
                {
                    if (cboxFiltros.Checked != true)//Sino se está utilixando filtros
                    {
                        ActualizarDataElectrica();
                    }
                    else
                    {
                        if (!VerificarCampoVacio())
                        {
                            //Filtrar 3
                            if (cmbFiltro.Text == "Carnet")//Filtro 1
                            {
                                Buscar(txtDato.Text, 3, 1);
                            }
                            else if (cmbFiltro.Text == "Nombres")//Filtro 2
                            {
                                Buscar(txtDato.Text, 3, 2);
                            }
                            else if (cmbFiltro.Text == "Primer apellido")//Filtro 3
                            {
                                Buscar(txtDato.Text, 3, 3);
                            }
                            else if (cmbFiltro.Text == "Segundo apellido")//Filtro 4
                            {
                                Buscar(txtDato.Text, 3, 4);
                            }
                            else
                            {
                                MessageBox.Show("POR FAVOR, SELECCIONE EL DATO A FILTRAR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                }
                else if (cmbCarreras.Text == "Ingeniería Industrial")//Carrera 4
                {
                    if (cboxFiltros.Checked != true)//Sino se está utilixando filtros
                    {
                        ActualizarDataIndustrial();
                    }
                    else
                    {
                        if (!VerificarCampoVacio())
                        {
                            //Filtrar 4
                            if (cmbFiltro.Text == "Carnet")//Filtro 1
                            {
                                Buscar(txtDato.Text, 4, 1);
                            }
                            else if (cmbFiltro.Text == "Nombres")//Filtro 2
                            {
                                Buscar(txtDato.Text, 4, 2);
                            }
                            else if (cmbFiltro.Text == "Primer apellido")//Filtro 3
                            {
                                Buscar(txtDato.Text, 4, 3);
                            }
                            else if (cmbFiltro.Text == "Segundo apellido")//Filtro 4
                            {
                                Buscar(txtDato.Text, 4, 4);
                            }
                            else
                            {
                                MessageBox.Show("POR FAVOR, SELECCIONE EL DATO A FILTRAR.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    } 
                }
            }
            else
            {
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
    }
}
