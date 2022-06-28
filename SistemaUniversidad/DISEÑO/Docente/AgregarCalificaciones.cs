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

namespace SistemaUniversidad.DISEÑO.Docente
{
    public partial class AgregarCalificaciones : Form
    {
        public Form aggCalificaciones;
        public AgregarCalificaciones()
        {
            InitializeComponent();
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Maximizar(this, sender, e, btnMaximizar, btnRestaurar);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu.MenuDocente Docente = new Menu.MenuDocente();
            this.Close();
            Docente.menuDocente = this;
            Docente.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            btnCerrar_Click(sender, e);
        }
    }
}
