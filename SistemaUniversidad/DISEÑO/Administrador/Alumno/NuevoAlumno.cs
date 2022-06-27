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
using SistemaUniversidad.DISEÑO;
using SistemaUniversidad.LOGICA.DATABASE;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace SistemaUniversidad.DISEÑO.Administrador
{
    public partial class NuevoAlumno : Form
    {
        public Form nuevoAlumno;
        public NuevoAlumno(){
            InitializeComponent();
            cmbCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void NuevoAlumno_Load(object sender, EventArgs e)
        {
            DateTime fechaInscripcion = DateTime.Today;
            txtFechaInscripcion.Text = fechaInscripcion.ToShortDateString().ToString();
            LimpiarTodo();

        }

        #region Limpiar
        private void LimpiarEtiquetas(){
            lblMensaje1.ForeColor = Color.Black;
            lblMensaje1.Text = "";

            lblMensaje2.ForeColor = Color.Black;
            lblMensaje2.Text = "";

            lblMensaje3.ForeColor = Color.Black;
            lblMensaje3.Text = "";

            lblMensaje4.ForeColor = Color.Black;
            lblMensaje4.Text = "";

            lblMensaje5.ForeColor = Color.Black;
            lblMensaje5.Text = "";

            lblMensaje6.ForeColor = Color.Black;
            lblMensaje6.Text = "";
        }
        public void LimpiarTodo(){
            cmbCarreras.Items.Clear();
            cmbCarreras.Items.Add("Ingeniería de Sistemas Informáticos");
            cmbCarreras.Items.Add("Ingeniería Agronómica");
            cmbCarreras.Items.Add("Ingeniería Eléctrica");
            cmbCarreras.Items.Add("Ingeniería Industrial");

            cmbEstadoCivil.Items.Clear();
            cmbEstadoCivil.Items.Add("Solter@");
            cmbEstadoCivil.Items.Add("Acompañad@");
            cmbEstadoCivil.Items.Add("Casad@");
            cmbEstadoCivil.Items.Add("Viud@");
            cmbEstadoCivil.Items.Add("Divorciad@");

            cmbNacionalidad.Items.Clear();
            cmbNacionalidad.Items.Add("El Salvador");
            cmbNacionalidad.Items.Add("Honduras");
            cmbNacionalidad.Items.Add("Guatemala");
            cmbNacionalidad.Items.Add("Nicaragua");
            cmbNacionalidad.Items.Add("Costa Rica");

            LimpiarEtiquetas();
            txtCarnet.Text = "";
            txtMatricula.Tag = "****";
            txtMatricula.Text = "****";
            txrtPrimerApellido.Text = "";//Hay que fijarse que tiene una "r" xD
            txtSegundoApellido.Text = "";
            txtNombres.Text = "";
            txtDocumentoIdentidad.Text = "";
            rbtnMasculino.Checked = false;
            rbtnFemenino.Checked = false;
            txtDireccion.Text = "";
            txtTelefono.Tag = "2624-0236";
            txtTelefono.Text = "2624-0236";
            txtTelefono.ForeColor = Color.DimGray;
            txtCelular.Tag = "7259-8563";
            txtCelular.Text = "7259-8563";
            txtCelular.ForeColor = Color.DimGray;
            txtCorreo.Tag = "universidad@gmail.com";
            txtCorreo.Text = "universidad@gmail.com";
            txtCorreo.ForeColor = Color.DimGray;
            dtPCalendarioNacimiento.Value = DateTime.Today;
        }
        private void btnLimpiar_Click(object sender, EventArgs e){
            LimpiarTodo();
        }
        #endregion

        #region Validaciones
        private void txtCarnet_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarEtiquetas();
            Validaciones validar = new Validaciones();
            validar.ValidarLetrasNumero(sender, e, lblMensaje1);
        }

        private void txrtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarEtiquetas();
            Validaciones validar = new Validaciones();
            validar.ValidarLetras(sender, e, lblMensaje2);
        }

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarEtiquetas();
            txrtPrimerApellido_KeyPress(sender, e);//Acá?
        }

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarEtiquetas();
            txrtPrimerApellido_KeyPress(sender, e);
        }

        private void txtDocumentoIdentidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarEtiquetas();
            Validaciones validar = new Validaciones();
            validar.ValidarDigitos(sender, e, lblMensaje3);
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarEtiquetas();
            Validaciones validar = new Validaciones();
            validar.ValidarDigitos(sender, e, lblMensaje4);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            LimpiarEtiquetas();
            Validaciones validar = new Validaciones();
            validar.ValidarDigitos(sender, e, lblMensaje5);
        }
        #endregion

        #region Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Today;
            LimpiarEtiquetas();
            //Valida los correos y números de teléfono
            string expresion = "[0-9]{4}-[0-9]{4}$";//formato para número de télefono
            string expresion2 = "^[_a-z0-9]+(.[_a-z0-9-])*@[a-z0-9]+(.[a-z0-9-]+)*\\.(.[a-z]{2,4})$";

            //Valida si todos los campos del formulario están llenos
            if (txtCarnet.Text != "" && cmbCarreras.Text != "" && txrtPrimerApellido.Text != ""
                && txtSegundoApellido.Text != "" && txtNombres.Text != "" && txtDocumentoIdentidad.Text != ""
                && true != (rbtnMasculino.Checked == true && rbtnFemenino.Checked == true) && txtDireccion.Text != ""
                && txtCelular.Text != "" && txtCorreo.Text != "" && cmbNacionalidad.Text != ""
                && cmbEstadoCivil.Text != "")
            {
                if (ValidarFecha()){
                    return;
                }
                //Si ingresó algún dato es porque sí tiene teléfono
                if (txtTelefono.Text != ""){
                    //Si el número de teléfono ingresado tiene el formato especificado
                    if (Regex.IsMatch(txtTelefono.Text, expresion)){
                        //lblMensaje4.Text = "Número válido";
                        if (Regex.Replace(txtTelefono.Text, expresion, string.Empty).Length == 0){
                            lblMensaje4.Text = "";
                        }
                        else{
                            lblMensaje4.Text = "";
                        }
                    }
                    else{
                        lblMensaje4.ForeColor = Color.Red;
                        lblMensaje4.Text = "Número Inválido";
                        return;
                    }
                }
                
                if (Regex.IsMatch(txtCelular.Text, expresion))
                {
                    //lblMensaje4.Text = "Número válido";
                    if (Regex.Replace(txtCelular.Text, expresion, string.Empty).Length == 0)
                    {
                        lblMensaje5.Text = "";
                    }
                    else
                    {
                        lblMensaje5.Text = "";
                    }
                }
                else
                {
                    lblMensaje5.ForeColor = Color.Red;
                    lblMensaje5.Text = "Número Inválido";
                    return;
                }
                //Si el mail ingresado tiene el formato especificado
                if (Regex.IsMatch(txtCorreo.Text, expresion2))
                {
                    if (Regex.Replace(txtCorreo.Text, expresion2, string.Empty).Length == 0)
                    {
                        lblMensaje5.Text = "";
                    }
                    else
                    {
                        lblMensaje5.Text = "";
                    }
                }
                else
                {
                    lblMensaje5.ForeColor = Color.Red;
                    lblMensaje5.Text = "Correo inválido";
                    return;
                }

                #region Guardar alumno
                //Si todo está completamente lleno
                //Verificacomo a qué carrera pertenece el nuevo alumnos para almacenarlo en la lista
                //que le corresponde
                string pass;
                Random aleatorio = new Random();
                int num = aleatorio.Next(20, 100);
                Alumno nuevoAlumno = new Alumno();
                nuevoAlumno.setNombres(txtNombres.Text);
                nuevoAlumno.setPrimerApellido(txrtPrimerApellido.Text);
                nuevoAlumno.setSegundoApellido(txtSegundoApellido.Text);
                nuevoAlumno.setCarnet(txtCarnet.Text);
                nuevoAlumno.setCarrera(cmbCarreras.Text);
                pass = nuevoAlumno.getNombres().Substring(0, 3)+nuevoAlumno.getPrimerApellido().Substring(0, 3) + num.ToString();
                nuevoAlumno.setPassword(pass);
                nuevoAlumno.setFechaNacimiento(dtPCalendarioNacimiento.Value.ToShortDateString());
                nuevoAlumno.setDocumentoIdentidad(txtDocumentoIdentidad.Text);
                if (rbtnFemenino.Checked)
                {
                    nuevoAlumno.setSexo("Femenino");
                }
                else if (rbtnMasculino.Checked)
                {
                    nuevoAlumno.setSexo("Masculino");
                }
                nuevoAlumno.setDireccion(txtDireccion.Text);
                if (txtTelefono.Text != txtTelefono.Tag.ToString())
                {
                    nuevoAlumno.setTelefono(txtTelefono.Text);
                }
                else
                {
                    nuevoAlumno.setTelefono("0000-0000");
                }
                nuevoAlumno.setCelular(txtCelular.Text);
                nuevoAlumno.setCorreo(txtCorreo.Text);
                nuevoAlumno.setFechaInscripcion(txtFechaInscripcion.Text);
                nuevoAlumno.setNacionalidad(cmbNacionalidad.Text);
                nuevoAlumno.setEtadoCivil(cmbEstadoCivil.Text);
                listaAlumnoGenerico.Add(nuevoAlumno);
                try {
                    this.SaveToDatabase();
                }catch(Exception error) {
                    MessageBox.Show("Error: " + error.Message);
                }
                #endregion

            }
            else
            {
                //Si al menos un campo no está lleno
                MessageBox.Show("ASEGURESE DE HABER LLENADO TODOS LOS CAMPOS DEL FORMULARIO", "ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            LimpiarTodo();
        }
        private bool ValidarFecha()
        {

            if (dtPCalendarioNacimiento.Value == DateTime.Today)
            {
                MessageBox.Show("FECHA INVALIDA, NO PUEDE SELECCIONAR LA FECHA ACTUAL", "Error de ingreso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            else if (dtPCalendarioNacimiento.Value > DateTime.Today)
            {
                MessageBox.Show("FECHA INVALIDA, NO PUEDE SELECCIONAR UNA FECHA FUTURA", "Error de ingreso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
        #endregion

        #region Regresar
        private void btnSalirAggAlumno_Click(object sender, EventArgs e)
        {
            Menu.MenuAdmin MenuAdmin = new Menu.MenuAdmin();
            this.Close();
            MenuAdmin.Show();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu.MenuAdmin MenuAdmin = new Menu.MenuAdmin();
            this.Close();
            MenuAdmin.Show();
        }
        #endregion

        #region Indicaciones txt
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            TextBox textb = (TextBox)sender;
            if (textb.Text == textb.Tag.ToString())
            {
                textb.Text = string.Empty;
                textb.ForeColor = Color.Black;
            }
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            TextBox textb = (TextBox)sender;
            if (string.IsNullOrEmpty(textb.Text))//Si el texto está nulo o vacío
            {
                textb.Text = textb.Tag.ToString();
                textb.ForeColor = Color.DimGray;
            }
        }
        #endregion
    }
}
