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
using SistemaUniversidad.DISEÑO.Menu;
using SistemaUniversidad.LOGICA.DATABASE;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Login{

    public partial class Login : Form{

        public Form logIn;
        public Login(){
            InitializeComponent();
        }

        #region Funciones Principales

        void VolverIncio(Form cerrar, object sender, EventArgs e){
            //Vuelve al Inicio
            if (MessageBox.Show("¿Seguro que desea volver?", "¡ATENCIÓN!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                Sesiones.Bienvenido formBienvenido = new Sesiones.Bienvenido();//Crea un objeto del formulario de incio
                formBienvenido.Show();//Se muestra el formulario de Inicio
                cerrar.Close();//Oculta éste formulario
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e){
            //Si el usuario Indica que "sí" desea salir if (MessageBox.Show("¿SEGURO QUE DESEA SALIR?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             VolverIncio(this, sender, e);
        }
        private void LimpiarEtiquetas(){
            lblMensaje1.Text = "";
            lblMensaje2.Text = "";
        }

        void GoToAdminPannel() {
            MenuAdmin FormAdmin = new MenuAdmin();
            FormAdmin.Show();
            this.Close();
            FormAdmin.menuAdmin = this;
        }

        void GoToProfessorPannel() {
            MenuDocente FormDocente = new MenuDocente();
            FormDocente.Show();
            this.Close();
        }

        void GoToStudentPannel() {
            MenuEstudiante FormEstudiante = new MenuEstudiante(txtCorreo.Text);
            FormEstudiante.Show();
            this.Close();
        }

        #endregion

        #region Acceder y cargar datos
        private void BtnAcceder_Click(object sender, EventArgs e) {

            if (txtCorreo.Text != "" && txtClave.Text != "") {
                try {
                    switch (ValidateUserLogin.CorrectCredentials(txtCorreo.Text, txtClave.Text)) {
                        case "Administrador":
                            GoToAdminPannel();
                            break;
                        case "Docente":
                            GoToProfessorPannel();
                            break;
                        case "Estudiante":
                            GoToStudentPannel();
                            break;
                        default:
                            MessageBox.Show("DATOS INCORRECTOS", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            } else {
                MessageBox.Show("ASEGURESE DE HABER LLENADO POR COMPLETO EL FORMULARIO.", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Validaciones
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e){
            Validaciones validar = new Validaciones();
            LimpiarEtiquetas();
            lblMensaje1.Visible = true;
            validar.ValidarEspacios(sender, e, lblMensaje1);
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e){
            Validaciones validar = new Validaciones();
            LimpiarEtiquetas();
            lblMensaje2.Visible = true;
            validar.ValidarEspacios(sender, e, lblMensaje2);
        }
        #endregion

        #region Maximizar, Minimizar y Cerrar
        private void btnMinimizar_Click(object sender, EventArgs e){
            BotonesPnlSuperior minimizar = new BotonesPnlSuperior();
            minimizar.Minimizar(this, sender, e);
        }
        private void btnCerrar_Click(object sender, EventArgs e){
            if (MessageBox.Show("¿SEGURO QUE DESEA CERRAR LA APLICACION?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){
                Application.Exit();
            }
        }
        #endregion
    }
}
