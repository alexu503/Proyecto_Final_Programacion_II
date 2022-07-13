using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA.LogicalClasses;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Administrador.Docentes {
    public partial class AgregarDocente : Form {

        string firstCareerSelected, secondCareerSelected;

        public AgregarDocente() {
            InitializeComponent();
        }

        private void btnCloseForm_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AgregarDocente_Load(object sender, EventArgs e) {
            this.LoadFirstCarrerToCmb();
            this.LoadSecondCareerToCmb();
            txtGetName.Focus();
        }

        void ReceibeInputs() {

            Proffessor professor = new Proffessor();
            professor.Name = FirstCharToUpper(txtGetName.Text.Trim());
            professor.FirstSurname = FirstCharToUpper(txtGetFirstSurname.Text.Trim());
            professor.SecondSurname = FirstCharToUpper(txtGetSecondSurname.Text.Trim());
            professor.CareerA = cmbGetFirstCareer.Text;
            professor.CareerB = cmbGetSecondCareer.Text;

            lstProfessor.Add(professor);

        }

        string FirstCharToUpper(string s) {
            // Check for empty string.  
            if (string.IsNullOrEmpty(s)) {
                return string.Empty;
            }
            // Return char and concat substring.  
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void txtGetName_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                MessageBox.Show("No se permiten números");
                txtGetName.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("No se permiten signos de puntuación");
                txtGetName.Clear();
            }
        }

        private void txtGetFirstSurname_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                MessageBox.Show("No se permiten números");
                txtGetFirstSurname.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("No se permiten signos de puntuación");
                txtGetFirstSurname.Clear();
            }
        }

        private void txtGetSecondSurname_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                MessageBox.Show("No se permiten números");
                txtGetSecondSurname.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("No se permiten signos de puntuación");
                txtGetSecondSurname.Clear();
            }
        }

        private void cmbGetFirstCareer_TextChanged(object sender, EventArgs e) {
            if (cmbGetFirstCareer.Text != "Seleccionar") {
                firstCareerSelected = cmbGetFirstCareer.Text;
            }
        }

        private void cmbGetSecondCareer_TextChanged(object sender, EventArgs e) {
            if (cmbGetSecondCareer.Text != "Seleccionar") {
                secondCareerSelected = cmbGetSecondCareer.Text;
            }
        }

        private void btnCancell_Click(object sender, EventArgs e) {
            txtGetName.Clear();
            txtGetFirstSurname.Clear();
            txtGetSecondSurname.Clear();
            cmbGetFirstCareer.Text = "Seleccionar";
            cmbGetSecondCareer.Text = "Seleccionar";
        }

        private void btnAgregar_Click(object sender, EventArgs e) {

            if(txtGetName.Text != "" && txtGetFirstSurname.Text != "" && txtGetSecondSurname.Text != "") {
                if(cmbGetFirstCareer.Text != "Seleccionar" && cmbGetSecondCareer.Text != "Seleccionar") {
                    this.ReceibeInputs();
                    try {
                        InsertData.InsertToProfessorTable(ref lstProfessor);
                        MessageBox.Show("Datos guardados correctamente");
                    } catch (Exception ex) {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                } else {
                    MessageBox.Show("Seleccione una carrera");
                }
            } else {
                MessageBox.Show("Rellene los campos requeridos");
            }
        }
    }
}
