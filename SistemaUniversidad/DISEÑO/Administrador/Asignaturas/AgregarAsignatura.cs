using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Administrador.Asignaturas {
    public partial class AgregarAsignatura : Form {
        public Form agregarAsignatura;
        public AgregarAsignatura() {
            InitializeComponent();
        }

        private void btnRestaurar_Click(object sender, EventArgs e) {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            //boton.Restaurar(this, sender, e, btnRestaurar, btnMaximizar);
        }

        private void btnMinimizar_Click(object sender, EventArgs e) {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Minimizar(this, sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            Menu.MenuAdmin MenuAdmin = new Menu.MenuAdmin();
            MenuAdmin.menuAdmin = this;
            this.Close();
            MenuAdmin.Show();
        }

        private void btnMaximizar_Click(object sender, EventArgs e) {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            //boton.Maximizar(this, sender, e, btnMaximizar, btnRestaurar);
        }

        private void AgregarAsignatura_Load(object sender, EventArgs e) {
            cmbCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        string FirstCharToUpper(string subjectName) {

            if (string.IsNullOrEmpty(subjectName)) {
                return string.Empty;
            }
            // Return char and concat substring.  
            return char.ToUpper(subjectName[0]) + subjectName.Substring(1);
        }

        private void btnGuardar_Click(object sender, EventArgs e) {

            if(cmbCarreras.Text != "Seleccionar" && txtGetNewSubjectName.Text != "" && cmbSelectProfessor.Text != "") {

                string career = cmbCarreras.Text;
                string subjectName = txtGetNewSubjectName.Text.Trim();
                string professorSelected = cmbSelectProfessor.Text;

                string newSubjectName = FirstCharToUpper(subjectName);

                try {
                    InsertData.AddNewSubject(ref career, ref newSubjectName, ref professorSelected);
                    MessageBox.Show("Materia agregada correctamente");
                } catch(Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                }
            } else {
                MessageBox.Show("Rellene los campos vacíos");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                MessageBox.Show("No se permiten números arábigos. Únicamente romanos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetNewSubjectName.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("No se permiten signos de puntuación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetNewSubjectName.Clear();
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

        private void btnReturnToMainForm_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
