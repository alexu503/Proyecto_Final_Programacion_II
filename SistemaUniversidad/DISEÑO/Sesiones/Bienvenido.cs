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
using System.Data.SQLite;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Sesiones {
    public partial class Bienvenido : Form {
        public Bienvenido() {
            InitializeComponent();
            btnIniciarSesion.TabStop = false;
            btnSignup.TabStop = false;
        }

        #region Mover el Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void pnlContBienve_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lblBienvenido_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void lblLineaDivisora_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        private void btnIniciarSesion_Click(object sender, EventArgs e) {
            Login.Login formLogin = new Login.Login();//Crea un objeto del formulario login
            this.Hide();//Oculta éste formulario
            formLogin.Show();//Se muestra el formulario de Login
        }

        private void btnCerrar_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btnSignup_Click(object sender, EventArgs e) {
            Registro.Signup signup = new Registro.Signup();
            this.Hide();//Oculta éste formulario
            signup.Show();//Se muestra el formulario de Login
        }
    }
}
