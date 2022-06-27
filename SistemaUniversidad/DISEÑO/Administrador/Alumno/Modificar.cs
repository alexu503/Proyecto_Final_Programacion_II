using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using SistemaUniversidad.LOGICA;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Administrador
{
    public partial class Modificar : Form
    {
        public Form modificar;
        public Modificar(){
            InitializeComponent();
            cmbCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbNacionalidad.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Modificar_Load(object sender, EventArgs e){
            this.LimpiarTodo();
            this.mostrar();
        }

        #region Limpiar
        private void LimpiarEtiquetas()
        {
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
        public void LimpiarTodo()
        {
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
        }
        #endregion

        private void btnSalirAggAlumno_Click(object sender, EventArgs e){
            ModificarAlumno Modificar = new ModificarAlumno();
            Modificar.modificarAlumno = this;
            this.Close();
            Modificar.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e){
            LimpiarTodo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Today;
            LimpiarEtiquetas();
            //Valida los correos y números de teléfono
            string expresion = "[0-9]{4}-[0-9]{4}$";//formato para número de télefono
            string expresion2 = "^[_a-z0-9]+(.[_a-z0-9-])*@[a-z0-9]+(.[a-z0-9-]+)*\\.(.[a-z]{2,4})$";
            //Valida si todos los campos del formulario están llenos
            if (txtTelefono.Text != "")//Si ingresó algún dato es porque sí tiene teléfono
            {
                //Si el número de teléfono ingresado tiene el formato especificado
                if (Regex.IsMatch(txtTelefono.Text, expresion))
                {
                    //lblMensaje4.Text = "Número válido";
                    if (Regex.Replace(txtTelefono.Text, expresion, string.Empty).Length == 0)
                    {
                        lblMensaje4.Text = "";
                    }
                    else
                    {
                        lblMensaje4.Text = "";
                    }
                }
                else
                {
                    lblMensaje4.ForeColor = Color.Red;
                    lblMensaje4.Text = "Número Inválido";
                    return;
                }
            }

            if (Regex.IsMatch(txtCelular.Text, expresion)){
                //lblMensaje4.Text = "Número válido";
                if (Regex.Replace(txtCelular.Text, expresion, string.Empty).Length == 0){
                    lblMensaje5.Text = "";
                }
                else{
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
            if (Regex.IsMatch(txtCorreo.Text, expresion2)){
                if (Regex.Replace(txtCorreo.Text, expresion2, string.Empty).Length == 0){
                    lblMensaje5.Text = "";
                }
                else{
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

            string sexo = "";

            if (rbtnFemenino.Checked){
                sexo = "Femenino";
            }
            else if (rbtnMasculino.Checked){
                sexo = "Femenino";
            }

            MySqlConnection connection = GenerateConnection.Connection();
            MySqlCommand command = new MySqlCommand();
            command.Connection =  connection;
            command.CommandText = "UPDATE Alumnos SET Nombres = '"+txtNombres.Text+"', PrimerApellido = '"+txtSegundoApellido.Text+"', SegundoApellido = '"+txtSegundoApellido.Text+"'," +
                "NombreCarrera = '"+cmbCarreras.Text+"', Carnet = '"+txtCarnet.Text+"', DocumentoDeIdentidad = '"+txtDocumentoIdentidad.Text+"', Sexo = '"+sexo+"', " +
                "Direccion = '"+txtDireccion.Text+"', Telefono = '"+txtTelefono.Text+"', Celular = '"+txtCelular.Text+"', Correo = '"+txtCorreo.Text+"', Nacionalidad = '"+cmbNacionalidad.Text+"', " +
                "EstadoCivil = '"+cmbEstadoCivil.Text+"' WHERE Nombres = '"+txtNombres.Text+"' AND Carnet = '"+previousCarnet+"'";
            command.CommandText = "UPDATE Logins SET Usuario = '"+txtCarnet.Text+"'";
            command.ExecuteNonQuery();
            connection.Close();
            #endregion

            LimpiarEtiquetas();
            MessageBox.Show("EL REGISTRO HA SIDO ACTUALIZADO CON EXITO", "¡ATENCION!" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnSalirAggAlumno_Click(sender,e);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            btnSalirAggAlumno_Click(sender,e);
        }
    }
}
