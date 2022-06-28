using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUniversidad.DISEÑO.Menu
{
    public partial class MenuDocente : Form
    {
        public Form menuDocente;
        private const int AnchoNormal = 200;
        private const int AnchoIconos = 62;
        public MenuDocente()
        {
            InitializeComponent();
        }

        #region Más opciones
        private void imgMasOpciones_Click_1(object sender, EventArgs e)
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
        private void btnGestionarCalificaciones_Click(object sender, EventArgs e)
        {
            Docente.AgregarCalificaciones AggCali = new Docente.AgregarCalificaciones();
            AggCali.aggCalificaciones = this;
            this.Close();
            AggCali.Show();
        }
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

        
    }
}
