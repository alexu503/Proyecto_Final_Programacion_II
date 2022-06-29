using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using SistemaUniversidad.LOGICA;
using SistemaUniversidad.LOGICA.DATABASE;

namespace SistemaUniversidad.DISEÑO.Docente
{
    public partial class AgregarCalificaciones : Form{

        bool cardExists;
        public Form aggCalificaciones;
        public AgregarCalificaciones(){
            InitializeComponent();
            cmbCarreras.Items.Add("Ingeniería de Sistemas Informáticos");
            cmbCarreras.Items.Add("Ingeniería Eléctrica");
            cmbCarreras.Items.Add("Ingeniería Agronómica");
            cmbCarreras.Items.Add("Ingeniería Industrial");
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

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            BotonesPnlSuperior boton = new BotonesPnlSuperior();
            boton.Maximizar(this, sender, e, btnMaximizar, btnRestaurar);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu.MenuDocente Docente = new Menu.MenuDocente();
            this.Close();
            Docente.menuDocente = this;
            Docente.Show();
        }

        private void btnRegresar_Click(object sender, EventArgs e){
            btnCerrar_Click(sender, e);
        }

        private void txtGetPrimerParcial_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetPrimerParcial.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetPrimerParcial.Clear();
            }
        }

        private void txtGetSegundoParcial_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetSegundoParcial.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetSegundoParcial.Clear();
            }
        }

        private void txtGetTercerParcial_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetTercerParcial.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetTercerParcial.Clear();
            }
        }

        private void txtGetCuartoParcial_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetCuartoParcial.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetCuartoParcial.Clear();
            }
        }

        private void txtGetPrimerLab_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetPrimerLab.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetPrimerLab.Clear();
            }
        }

        private void txtGetSegundoLab_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetSegundoLab.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetSegundoLab.Clear();
            }
        }

        private void txtGetTecerLab_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetTercerLab.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetTercerLab.Clear();
            }
        }

        private void txtGetCuartoLab_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetCuartoLab.Clear();
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGetCuartoLab.Clear();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e) {

            MySqlConnection connection = GenerateConnection.Connection();
            MySqlCommand query = new MySqlCommand();
            query.Connection = connection;

            try {
                query.CommandText = "SELECT * FROM Notas WHERE NombreCarrera = '"+cmbCarreras.Text+"' AND CarnetAlumno = '"+cmbGetCarnet.Text+"'";
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = query;
                DataTable table = new DataTable();
                da.Fill(table);
                dgvAlumnos.DataSource = table;
                MessageBox.Show("DATOS ACTUALIZADOS", "ATENCIÓN", MessageBoxButtons.OK);
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                connection.Close();
            }
        }

        //private void btnAsignarNota_Click(object sender, EventArgs e) {
        //
        //    
        //}

        void FillCmbGetCarnet() {
            string query = "Select Carnet FROM Alumnos WHERE NombreCarrera = '"+cmbCarreras.Text+"'";
            MySqlConnection connection = GenerateConnection.Connection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            MySqlDataReader dr = command.ExecuteReader();

            try {
                if (dr.HasRows) {
                    while (dr.Read()) {
                        cmbGetCarnet.Items.Add(dr.GetString("Carnet"));
                    }
                } else {
                    MessageBox.Show("AUN NO HAY ALUMNOS INSCRITOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbMaterias.Enabled = false;
                    cmbGetCarnet.Enabled = false;
                    txtGetPrimerParcial.Enabled = false;
                    txtGetPrimerLab.Enabled = false;
                    txtGetSegundoParcial.Enabled = false;
                    txtGetSegundoLab.Enabled = false;
                    txtGetTercerParcial.Enabled = false;
                    txtGetTercerLab.Enabled = false;
                    txtGetCuartoParcial.Enabled = false;
                    txtGetCuartoLab.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnAsignarNota.Enabled = false;
                    return;
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                dr.Close();
                connection.Close();
            }
        }

        void FilCmbMaterias() {
            string query = "Select NombreMateria FROM Materias";
            MySqlConnection connection = GenerateConnection.Connection();
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();
            MySqlDataReader dr = command.ExecuteReader();

            try {
                if (dr.HasRows) {
                    while (dr.Read()) {
                        cmbMaterias.Items.Add(dr.GetString("NombreMateria"));
                    }
                } else {
                    MessageBox.Show("NO HAY MATERIAS DISPONIBLES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmbMaterias.Enabled = false;
                    cmbGetCarnet.Enabled = false;
                    txtGetPrimerParcial.Enabled = false;
                    txtGetPrimerLab.Enabled = false;
                    txtGetSegundoParcial.Enabled = false;
                    txtGetSegundoLab.Enabled = false;
                    txtGetTercerParcial.Enabled = false;
                    txtGetTercerLab.Enabled = false;
                    txtGetCuartoParcial.Enabled = false;
                    txtGetCuartoLab.Enabled = false;
                    btnActualizar.Enabled = false;
                    btnAsignarNota.Enabled = false;
                    return;
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                dr.Close();
                connection.Close();
            }
        }

        private void cmbCarreras_SelectedValueChanged(object sender, EventArgs e) {
            this.FilCmbMaterias();
            this.FillCmbGetCarnet();
        }

        private void btnAsignarNota_Click_1(object sender, EventArgs e) {
            Calificaciones calificaciones = new Calificaciones();

            if (cmbCarreras.Text != "" && cmbMaterias.Text != "" && cmbGetCarnet.Text != "") {
                if (txtGetPrimerParcial.Text != "" && txtGetSegundoParcial.Text != "" && txtGetTercerParcial.Text != "" && txtGetCuartoParcial.Text != "") {
                    if (txtGetPrimerLab.Text != "" && txtGetSegundoLab.Text != "" && txtGetTercerLab.Text != "" && txtGetCuartoLab.Text != "") {

                        calificaciones.PrimerParcial = int.Parse(txtGetPrimerParcial.Text);
                        calificaciones.SegundoParcial = int.Parse(txtGetSegundoParcial.Text);
                        calificaciones.TercerParcial = int.Parse(txtGetTercerParcial.Text);
                        calificaciones.CuartoParcial = int.Parse(txtGetCuartoParcial.Text);
                        calificaciones.PrimerLab = int.Parse(txtGetPrimerLab.Text);
                        calificaciones.SegundoLab = int.Parse(txtGetSegundoLab.Text);
                        calificaciones.TercerLab = int.Parse(txtGetTercerLab.Text);
                        calificaciones.CuartoLab = int.Parse(txtGetCuartoLab.Text);

                        double promedioComputo1 = ((int.Parse(txtGetPrimerParcial.Text)) * 0.15f) + ((int.Parse(txtGetPrimerLab.Text)) * 0.1f);
                        double promedioComputo2 = ((int.Parse(txtGetSegundoParcial.Text)) * 0.15f) + ((int.Parse(txtGetSegundoLab.Text)) * 0.1f);
                        double promedioComputo3 = ((int.Parse(txtGetTercerParcial.Text)) * 0.15f) + ((int.Parse(txtGetTercerLab.Text)) * 0.1f);
                        double promedioComputo4 = ((int.Parse(txtGetCuartoParcial.Text)) * 0.15f) + ((int.Parse(txtGetCuartoLab.Text)) * 0.1f);


                        double promedio = (promedioComputo1 + promedioComputo2 + promedioComputo3 + promedioComputo4);
                        promedio = Math.Round(promedio, 2);
                        calificaciones.Promedio = promedio/100;
                        lstCalificaciones.Add(calificaciones);
                        this.UpdateData();
                    } else {
                        MessageBox.Show("RELLENE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("RELLENE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show("RELLENE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
