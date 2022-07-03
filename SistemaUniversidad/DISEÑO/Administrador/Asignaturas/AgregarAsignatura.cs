using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaUniversidad.LOGICA;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Administrador.Asignaturas
{
    public partial class AgregarAsignatura : Form
    {
        public Form agregarAsignatura;
        public AgregarAsignatura()
        {
            InitializeComponent();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Restaurar(this, sender, e, btnRestaurar, btnMaximizar);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Minimizar(this, sender, e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu.MenuAdmin MenuAdmin = new Menu.MenuAdmin();
            MenuAdmin.menuAdmin = this;
            this.Close();
            MenuAdmin.Show();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Maximizar(this, sender, e, btnMaximizar, btnRestaurar);
        }

        private void AgregarAsignatura_Load(object sender, EventArgs e) {
            cmbCarreras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCarreras.Items.Add("Ingeniería de Sistemas Informáticos");
            cmbCarreras.Items.Add("Ingeniería Agronómica");
            cmbCarreras.Items.Add("Ingeniería Eléctrica");
            cmbCarreras.Items.Add("Ingeniería Industrial");
        }

        private void btnGuardar_Click(object sender, EventArgs e) {
            //if(cmbCarreras.Text != "") {
            //    if(txtNombre.Text != "" || txtNombre.Text.Length < 7) {
            //        MySqlConnection connection = GenerateConnection.Connection();
            //        MySqlCommand query = new MySqlCommand();
            //        query.Connection = connection;
            //
            //        try {
            //            query.CommandText = "INSERT INTO Materias(NombreCarrera, NombreMateria) VALUES('"+cmbCarreras.Text+"', '"+txtNombre.Text+"')";
            //            query.ExecuteNonQuery();
            //
            //            MessageBox.Show("DATOS GUARDADOS", "ATENCIÓN", MessageBoxButtons.OK);
            //            cmbCarreras.Text = "";
            //            txtNombre.Clear();
            //
            //        }catch(Exception ex) {
            //            MessageBox.Show("Error: " + ex.Message);
            //        } finally {
            //            connection.Close();
            //        }
            //    } else {
            //        MessageBox.Show("INGRESE EL NOMBRE DE LA MATERIA CORRECTAMENTE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //} else {
            //    MessageBox.Show("SELECCIONE UNA CARRERA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsDigit(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN NÚMEROS ARÁBIGOS. EN SU LUGAR, USE NÚMEROS ROMANOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Clear();
            }
        }
    }
}
