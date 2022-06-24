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
using SistemaUniversidad.DISEÑO.Menu;

namespace SistemaUniversidad.DISEÑO.Login
{
    public partial class Login : Form
    {
        public Form logIn;
        public Login()
        {
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

        #region Acceder
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "" && txtClave.Text != "")
            {
                //Si todos los campos del formulario están llenos validamos que los datos sean correctos

                /*
                 * ---->    DATOS PARA INGRESO (PRUEBAS)     <----
                 * 
                 * -> USERS TYPE          EMAIL              PASSWORD
                 * -> Administrador       admin               123456
                 * -> Docente             docente             654321
                 * -> Estudiante          estudiante          987654
                */

                //Valida si los datos ingresados para entrar como "Administrador" son correctos
                if (txtCorreo.Text == "admin" && txtClave.Text == "123456")
                {
                    /*
                     * ----> ABRE EL MENU DE ADMINISTRADOS
                    */
                    MenuAdmin FormAdmin = new MenuAdmin();
                    this.Hide();
                    FormAdmin.Show();
                    FormAdmin.menuAdmin = this;
                    //Acá irá el código para pasar las listas
                }
                //Valida si los datos ingresados para entrar como "Docente" son correctos
                else if (txtCorreo.Text == "docente" && txtClave.Text == "654321")
                {
                    /*
                     * ----> ABRE EL MENU DE DOCENTE
                    */
                    MenuDocente FormDocente = new MenuDocente();
                    FormDocente.Show();
                    this.Close();
                }
                //Valida si los datos ingresados para entrar como "Estudiante" son correctos
                else if (txtCorreo.Text == "estudiante" && txtClave.Text == "987654")
                {
                    /*
                     * ----> ABRE EL MENU DE ALUMNO
                    */
                    MenuEstudiante FormEstudiante = new MenuEstudiante();
                    FormEstudiante.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("USUARIO NO ENCONTRADO, ASEGURESE DE HABER INSERTADO LOS DATOS CORRECTAMENTE", "¡ATENCION!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
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
