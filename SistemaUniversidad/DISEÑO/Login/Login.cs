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
using SistemaUniversidad.DISEÑO.Menu;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Login
{
    public partial class Login : Form
    {
        public Form logIn;
        public Login(){
            InitializeComponent();
        }

        #region Funciones Principales
        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        public void VolverIncio(Form cerrar, object sender, EventArgs e)
        {
            //Vuelve al Inicio
            if (MessageBox.Show("¿SEGURO QUE DESEA VOLVER?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Sesiones.Bienvenido formBienvenido = new Sesiones.Bienvenido();//Crea un objeto del formulario de incio
                formBienvenido.Show();//Se muestra el formulario de Inicio
                cerrar.Close();//Oculta éste formulario
                
            }
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Si el usuario Indica que "sí" desea salir if (MessageBox.Show("¿SEGURO QUE DESEA SALIR?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             VolverIncio(this, sender, e);
        }
        private void LimpiarEtiquetas()
        {
            lblMensaje1.Text = "";
            lblMensaje2.Text = "";
        }
        #endregion

        #region Acceder y cargar datos
        private void btnAcceder_Click(object sender, EventArgs e){
            if (txtCorreo.Text != "" && txtClave.Text != ""){

                try {
                    MySqlConnection connection = GenerateConnection.Connection();
                    MySqlCommand query = new MySqlCommand();
                    query.Connection = connection;
                    query.CommandText = "SELECT Usuario, Clave, Rol FROM Logins WHERE Usuario = @User AND Clave = @Pass;";
                    query.Parameters.Add(new MySqlParameter("@User", txtCorreo.Text));
                    query.Parameters.Add(new MySqlParameter("@Pass", txtClave.Text));
                    MySqlDataReader dr = query.ExecuteReader();

                    while (dr.Read()) {

                        string username = dr["Usuario"].ToString();
                        string password = dr["Clave"].ToString();
                        string rol = dr["Rol"].ToString();

                        if (username == txtCorreo.Text && password == txtClave.Text) {
                            switch (rol) {
                                case "Administrador":
                                    if (username == "root" && password == txtClave.Text) {
                                        MenuAdmin FormAdmin = new MenuAdmin();
                                        this.Hide();
                                        FormAdmin.Show();
                                        FormAdmin.menuAdmin = this;
                                    } else {
                                        MessageBox.Show("DATOS INCORRECTOS", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                case "Docente":
                                    if (username == txtCorreo.Text && password == txtClave.Text) {
                                        MenuDocente FormDocente = new MenuDocente();
                                        FormDocente.Show();
                                        this.Close();
                                    } else {
                                        MessageBox.Show("DATOS INCORRECTOS", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                case "Estudiante":
                                    if (username == txtCorreo.Text && password == txtClave.Text) {
                                        MenuEstudiante FormEstudiante = new MenuEstudiante(txtCorreo.Text);
                                        FormEstudiante.Show();
                                        this.Close();
                                    } else {
                                        MessageBox.Show("DATOS INCORRECTOS", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                    break;
                                default:
                                    MessageBox.Show("Error: datos incorrectos");
                                    break;
                            }
                        }
                    }
                    connection.Close();
                } catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            } else {
                MessageBox.Show("ASEGURESE DE HABER LLENADO POR COMPLETO EL FORMULARIO.", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Validaciones
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones validar = new Validaciones();
            LimpiarEtiquetas();
            lblMensaje1.Visible = true;
            validar.ValidarEspacios(sender, e, lblMensaje1);
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validaciones validar = new Validaciones();
            LimpiarEtiquetas();
            lblMensaje2.Visible = true;
            validar.ValidarEspacios(sender, e, lblMensaje2);
        }
        #endregion

        #region Maximizar, Minimizar y Cerrar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior minimizar = new BotonesPnlSuperior();
            minimizar.Minimizar(this, sender, e);
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿SEGURO QUE DESEA CERRAR LA APLICACION?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }
        #endregion

    }
}
