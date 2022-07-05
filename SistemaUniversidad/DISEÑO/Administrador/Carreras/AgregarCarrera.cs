using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SistemaUniversidad.DISEÑO.Menu;
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
            if (MessageBox.Show("¿Seguro que desea salir?", "Atención", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
                this.Close();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        string GetFirstCharToUpper(string career) {
            // Check for empty string.  
            if (string.IsNullOrEmpty(career)) {
                return string.Empty;
            }
            // Return char and concat substring.  
            return char.ToUpper(career[0]) + career.Substring(1);
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if(txtGetCareerName.Text != "") {
                try {
                    InsertData.AddNewCareer(GetFirstCharToUpper(txtGetCareerName.Text.Trim()));
                    MessageBox.Show("Agergado exitosamente");
                    txtGetCareerName.Clear();
                }
                catch(Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancell_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desea salir?", "Atención", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
                this.Close();
            }
        }
    }
}
