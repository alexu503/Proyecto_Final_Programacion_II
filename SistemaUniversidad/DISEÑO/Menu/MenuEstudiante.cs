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

namespace SistemaUniversidad.DISEÑO.Menu
{
    public partial class MenuEstudiante : Form
    {
        public Form menuEstudiante;
        private const int AnchoNormal = 200;
        private const int AnchoIconos = 62;
        string loginID = "";
        public MenuEstudiante(string carnetAlumno){
            InitializeComponent();
            this.loginID = carnetAlumno;
        }
        private void MenuEstudiante_Load(object sender, EventArgs e)
        {
            
        }

        #region Abrir Sub-Menú
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿SEGURO QUE DESEA CERRAR SESION?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login.Login FormLogIn = new Login.Login();
                this.Hide();
                FormLogIn.logIn = this;
                FormLogIn.Show();
            }
        }
        #endregion

        #region Botones Minimizar Maximizar Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿SEGURO QUE DESEA CERRAR LA APLICACIÓN?", "¡ATENCION!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Maximizar(this, sender, e, btnMaximizar, btnRestaurar);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Restaurar(this, sender, e, btnRestaurar, btnMaximizar);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Minimizar(this, sender, e);
        }
        #endregion

        #region Más opciones
        private void imgMasOpciones_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            imgMasOpciones.Enabled = false;
            if (pnlMenuLateral.Width != AnchoIconos)
            {
                pnlMenuLateral.Width = AnchoIconos;
                //Acá debe ir el código de ocultar los submenús.
                pnlHome.Width = AnchoIconos;
            }
            else
            {
                pnlMenuLateral.Width = AnchoNormal;
                pnlHome.Width = AnchoNormal;
            }
            this.Cursor = Cursors.Default;
            imgMasOpciones.Enabled = true;
        }

        #endregion

        private void btnGestionarCalificaciones_Click(object sender, EventArgs e) {
            Estudiante.VerRegistro Buscar = new Estudiante.VerRegistro(this.loginID);
            this.Close();
            Buscar.buscarMateria = this;
            Buscar.Show();
        }
    }
}
