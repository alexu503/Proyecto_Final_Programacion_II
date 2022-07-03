using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Mail;
using SistemaUniversidad.LOGICA.LogicalClasses;
using SistemaUniversidad.LOGICA.DATABASE.Queries;

namespace SistemaUniversidad.DISEÑO.Registro {
    public partial class Signup : Form {
        public Signup() {
            InitializeComponent();
        }

        bool ValidateDate() {

            if (dtPGetBirthday.Value == DateTime.Today)
                return false;
            else if (dtPGetBirthday.Value > DateTime.Today)
                return false;
            else
                return true;
        }

        //bool ValidatePhone(ref string regex) {
        //    if(Regex.IsMatch(txtGetMobilePhone.Text, regex))
        //        return false;
        //    if (Regex.IsMatch(txtGetPhone.Text, regex))
        //        return false;
        //    else
        //        return true;
        //}
        //
        //bool ValidateEmail(string email) {
        //    try {
        //        MailAddress m = new MailAddress(email);
        //        return true;
        //    } catch (FormatException) {
        //        return false;
        //    }
        //}

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

        private void txtGetDNI_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("No se permiten letras", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetDNI.Clear();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e) {

            string phoneCheckerRegex = "(+503|503| )?[ -]*(6|7)[ -]*([0-9][ -]*){8}"; //Formato para número de télefono

            if (txtGetLastname.Text != "" && txtGetName.Text != "" &&txtGetDNI.Text != "" && txtGetEmail.Text != "" && txtGetMobilePhone.Text != "" && txtGetAddress.Text != "") {
                if (ValidateDate()) {
                    if (cmbGetNationality.Text != "" && cmbGetMaritalStatus.Text != "" && cmbGetCareer.Text != "") {
                        if(rbtnMale.Checked == true || rbtnFemale.Checked == true) {
                            ReceiveInputs();
                            try {
                                InsertData.InsertToDB("Estudiante", ref lstStudent);
                                MessageBox.Show("Registrado correctamente");
                            } catch (Exception ex) {
                                MessageBox.Show("Error: " + ex.Message);
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

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlSuperior_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancell_Click(object sender, EventArgs e) {
            txtGetName.Clear();
            txtGetLastname.Clear();
            dtPGetBirthday.ResetText();
            txtGetDNI.Clear();
            txtGetEmail.Clear();
            txtGetMobilePhone.Clear();
            txtGetPhone.Clear();
            txtGetAddress.Clear();
            cmbGetNationality.Text = "";
            cmbGetMaritalStatus.Text = "";
            cmbGetCareer.Text = "";
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            if (MessageBox.Show("¿Seguro que desea salir?", "¡Atención!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                Sesiones.Bienvenido bienvenido = new Sesiones.Bienvenido();
                this.Hide();
                bienvenido.Show();
            }
        }

        private void txtGetEmail_Enter(object sender, EventArgs e) {
            txtGetEmail.Clear();
            txtGetEmail.ForeColor = System.Drawing.Color.Black;
        }

        private void txtGetMobilePhone_Enter(object sender, EventArgs e) {
            txtGetMobilePhone.Clear();
            txtGetMobilePhone.ForeColor = System.Drawing.Color.Black;
        }

        private void txtGetPhone_Enter(object sender, EventArgs e) {
            txtGetPhone.Clear();
            txtGetPhone.ForeColor = System.Drawing.Color.Black;
        }

        private void txtGetEmail_Leave(object sender, EventArgs e) {
            txtGetEmail.Tag = "universidad@gmail.com";
            txtGetEmail.Text = "universidad@gmail.com";
            txtGetEmail.ForeColor = System.Drawing.Color.Gray;
        }

        private void txtGetMobilePhone_Leave(object sender, EventArgs e) {
            txtGetMobilePhone.Tag = "7259-8563";
            txtGetMobilePhone.Text = "7259-8563";
            txtGetMobilePhone.ForeColor = System.Drawing.Color.Gray;
        }

        private void txtGetPhone_Leave(object sender, EventArgs e) {
            txtGetPhone.Tag = "2665-0925";
            txtGetPhone.Text = "2665-0925";
            txtGetPhone.ForeColor = System.Drawing.Color.Gray;
        }
    }
}
