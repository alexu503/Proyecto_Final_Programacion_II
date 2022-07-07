using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SistemaUniversidad.DISEÑO.Menu;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Administrador.Carreras {
    public partial class EliminarCarrera : Form {
        public EliminarCarrera() {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EliminarCarrera_Load(object sender, EventArgs e) {
            //EDIT THIS:
            //try {
            //    LoadCareers();
            //}catch(Exception ex) {
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desea salir?", "Atención", MessageBoxButtons.OKCancel) == DialogResult.OK) {
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

        private void btnDelete_Click(object sender, EventArgs e) {
            if(cmbDeleteCareers.Text != "Seleccionar") {
                string carrerToDelete = cmbDeleteCareers.Text;

                try {
                    if (MessageBox.Show("¿Seguro que desea continuar?", "Atención", MessageBoxButtons.OKCancel) == DialogResult.OK) {
                        DeleteData.DeleteCareer(ref carrerToDelete);
                    }
                    MessageBox.Show("Carrera eliminada satisfactoriamente");
                } catch(Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                } finally {
                    cmbDeleteCareers.Text = "Seleccionar";
                }
            }
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
