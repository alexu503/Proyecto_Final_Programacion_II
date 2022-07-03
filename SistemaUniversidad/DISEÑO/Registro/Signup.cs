using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA.LogicalClasses;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Registro {
    public partial class Signup : Form {
        public Signup() {
            InitializeComponent();
        }

        bool ValidateDate() {

            if (dtPGetBirthday.Value == DateTime.Today) {
                return false;
            } else if (dtPGetBirthday.Value > DateTime.Today) {
                return false;
            } else {
                return true;
            }
        }

        bool ValidatePhone(ref string regex) {
            if(Regex.IsMatch(txtGetMobilePhone.Text, regex))
                return true;
            if (Regex.IsMatch(txtGetPhone.Text, regex))
                return true;
            else
                return false;
        }

        bool ValidateEmail(ref string regex) {
            if (Regex.IsMatch(txtGetEmail.Text, regex))
                return true;
            else
                return false;
        }

        void ReceiveInputs() {
            Student student = new Student();

            student.FirstName = txtGetName.Text;
            student.Lastname = txtGetLastname.Text;
            student.BirthDate = dtPGetBirthday.Text;
            student.DNI = txtGetDNI.Text;
            student.Email = txtGetEmail.Text;
            student.MobilePhone = txtGetMobilePhone.Text;
            student.Phone = txtGetPhone.Text;
            student.Address = txtGetAddress.Text;
            student.Nationality = cmbGetNationality.Text;
            student.MaritalStatus = cmbGetMaritalStatus.Text;
            student.CareerA = cmbGetCareer.Text;

            if (rbtnMale.Checked)
                student.Sex = "Masculino";
            if (rbtnFemale.Checked)
                student.Sex = "Femenino";

            lstStudent.Add(student);
        }

        private void txtGetLastname_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                MessageBox.Show("No se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetLastname.Clear();
            }
            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("No se permiten signos de puntuación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetLastname.Clear();
            }
        }

        private void txtGetName_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                MessageBox.Show("No se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetName.Clear();
            }
            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("No se permiten signos de puntuación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetName.Clear();
            }
        }

        private void txtGetDNI_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                MessageBox.Show("No se permiten números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetDNI.Clear();
            }
            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("No se permiten signos de puntuación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetDNI.Clear();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e) {

            string phoneCheckerRegex = "(2|6|7)[0-9]{4}-[0-9]{4}$"; //Formato para número de télefono
            string emailCheckerRegex = "^[_a-z0-9]+(.[_a-z0-9-])*@[a-z0-9]+(.[a-z0-9-]+)*\\.(.[a-z]{2,4})$"; //Formato para email.

            if (txtGetLastname.Text != "" && txtGetName.Text != "" &&txtGetDNI.Text != "" && txtGetEmail.Text != "" && txtGetMobilePhone.Text != "" && txtGetPhone.Text != "" && txtGetAddress.Text != "") {
                if (ValidateDate()) {
                    if (cmbGetNationality.Text != "" && cmbGetMaritalStatus.Text != "" && cmbGetCareer.Text != "") {
                        if(rbtnMale.Checked == true || rbtnFemale.Checked == true) {
                            if(ValidatePhone(ref phoneCheckerRegex) && ValidateEmail(ref emailCheckerRegex)) {
                                ReceiveInputs();
                                InsertData.InsertToDB("Estudiante", ref lstStudent);
                            } else {
                                MessageBox.Show("Número de teléfono o correo inválidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        } else {
                            MessageBox.Show("Seleccione un sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else {
                        MessageBox.Show("Seleccione los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("Fecha inválida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
