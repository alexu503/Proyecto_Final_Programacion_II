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

namespace SistemaUniversidad.DISEÑO.Estudiante
{
    public partial class BuscarAsignaturas : Form
    {
        public Form buscarMateria;
        public BuscarAsignaturas()
        {
            InitializeComponent();
        }
        private void BuscarAsignaturas_Load(object sender, EventArgs e)
        {
            cmbCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
            Limpiar();
        }

        private void Limpiar()
        {
            cmbCarreras.Items.Clear();
            cmbCarreras.Items.Add("Ingeniería de Sistemas Informáticos");
            cmbCarreras.Items.Add("Ingeniería Agronómica");
            cmbCarreras.Items.Add("Ingeniería Eléctrica");
            cmbCarreras.Items.Add("Ingeniería Industrial");
        }

        #region Botones Minimizar Maximizar Cerrar
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Restaurar(this, sender, e, btnRestaurar, btnMaximizar);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu.MenuEstudiante Estudiante = new Menu.MenuEstudiante();
            this.Close();
            Estudiante.menuEstudiante = this;
            Estudiante.Show();
        }

        #endregion

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnCerrar_Click(sender, e);
        }

    }
}
