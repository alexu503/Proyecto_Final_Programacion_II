using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaUniversidad.DISEÑO.Menu;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Administrador.Carreras {
    public partial class ModificarCarrera : Form {
        public ModificarCarrera() {
            InitializeComponent();
        }

        private void txtGetNewName_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Error: no se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetNewName.Clear();
            }
            if (char.IsPunctuation(e.KeyChar)) {
                e.Handled = true;
                MessageBox.Show("Error: no se permiten signos de puntuación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetNewName.Clear();
            }
        }

        public static string FirstCharToUpper(string s) {
            // Check for empty string.  
            if (string.IsNullOrEmpty(s)) {
                return string.Empty;
            }
            // Return char and concat substring.  
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            if(txtGetNewName.Text != "") {
                string oldCareerName = cmbGetCareersList.Text;
                string newCareerName = FirstCharToUpper(txtGetNewName.Text.Trim());

                UpdateData.UpdateCareers(ref oldCareerName, ref newCareerName);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ModificarCarrera_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ModificarCarrera_Load(object sender, EventArgs e) {
            try {
                LoadCareers();
            }catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            if(MessageBox.Show("¿Seguro que desea salir?", "Atención", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
                this.Close();
            }
        }

        private void btnCancell_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desea salir?", "Atención", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                MenuAdmin menuAdmin = new MenuAdmin();
                menuAdmin.Show();
                this.Close();
            }
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
