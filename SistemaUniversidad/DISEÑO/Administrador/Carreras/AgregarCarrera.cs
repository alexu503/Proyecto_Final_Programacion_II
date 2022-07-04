using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Administrador.Carreras {
    public partial class AgregarCarrera : Form {
        public AgregarCarrera() {
            InitializeComponent();
        }

        private void txtGetCareerName_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                MessageBox.Show("No se permiten números");
                txtGetCareerName.Clear();
            }
            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("No se permiten signos de puntuación");
                txtGetCareerName.Clear();
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            Menu.MenuAdmin MenuAdmin = new Menu.MenuAdmin();
            this.Close();
            MenuAdmin.Show();
        }

        private void btnMinimizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if(txtGetCareerName.Text != "") {
                InsertData.AddNewCareer(txtGetCareerName.Text.ToUpper().Trim());
            }
        }
    }
}
