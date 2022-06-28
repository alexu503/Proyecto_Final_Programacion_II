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
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGetSegundoParcial_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGetTercerParcial_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGetCuartoParcial_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGetPrimerLab_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGetSegundoLab_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGetTecerLab_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtGetCuartoLab_KeyPress(object sender, KeyPressEventArgs e) {
            if (char.IsLetter(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN LETRAS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (char.IsPunctuation(e.KeyChar)) {
                MessageBox.Show("NO SE PERMITEN SIGNOS DE PUNTUACIÓN. AGREGUE UNA NOTA ENTERA. \nEJEMPLO: 75", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e) {

            MySqlConnection connection = GenerateConnection.Connection();
            MySqlCommand query = new MySqlCommand();
            query.Connection = connection;

            if(cmbCarreras.Text == "" && txtGetCarnetAlumno.Text != "") {

                try {
                    query.CommandText = "SELECT * FROM Materias WHERE Carrera = '"+cmbCarreras.Text+"' AND Carnet = '"+txtGetCarnetAlumno.Text+"'";
                    MessageBox.Show("NOTAS GUARDADAS", "ATENCIÓN", MessageBoxButtons.OK);
                } catch(Exception ex) {
                    MessageBox.Show("Error: " + ex.Message);
                } finally {
                    connection.Close();
                }
            } else {
                MessageBox.Show("SELECCIONE UNA CARRERA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool LookForCard(string card) {

            string query = "Select NombreMateria FROM Materias";
            MySqlConnection connection = GenerateConnection.Connection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dr = command.ExecuteReader();

            try {
                while (dr.Read()) {

                    if (card == dr.GetString("CarnetAlumno")) {
                        cardExists = true;
                    } else {
                        cardExists = false;
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                dr.Close();
                connection.Close();
            }
            return cardExists;
        }

        private void btnAsignarNota_Click(object sender, EventArgs e) {

            Calificaciones calificaciones = new Calificaciones();

            if(cmbCarreras.Text != "" && cmbMaterias.Text != "" && txtGetCarnetAlumno.Text != "") {
                if (LookForCard(txtGetCarnetAlumno.Text)) {
                    if (txtGetPrimerParcial.Text != "" && txtGetSegundoParcial.Text != "" && txtGetTercerParcial.Text != "" && txtGetCuartoParcial.Text != "") {
                        if (txtGetPrimerLab.Text != "" && txtGetSegundoLab.Text != "" && txtGetTercerLab.Text != "" && txtGetCuartoLab.Text != "") {
                            if ((int.Parse(txtGetPrimerParcial.Text) > 100 && int.Parse(txtGetPrimerParcial.Text) < 0) || (int.Parse(txtGetSegundoParcial.Text) > 100 && int.Parse(txtGetSegundoParcial.Text) < 0) || (int.Parse(txtGetTercerParcial.Text) > 100 && int.Parse(txtGetTercerParcial.Text) < 0) || (int.Parse(txtGetCuartoParcial.Text) > 100 && int.Parse(txtGetCuartoParcial.Text) < 0)) {
                                if ((int.Parse(txtGetPrimerLab.Text) > 100 && int.Parse(txtGetPrimerLab.Text) < 0) || (int.Parse(txtGetSegundoLab.Text) > 100 && int.Parse(txtGetSegundoLab.Text) < 0) || (int.Parse(txtGetTercerLab.Text) > 100 && int.Parse(txtGetTercerLab.Text) < 0) || (int.Parse(txtGetCuartoLab.Text) > 100 && int.Parse(txtGetCuartoLab.Text) < 0)) {
                                    MessageBox.Show("NOTA INCORRECTA", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                } else {
                                    calificaciones.PrimerParcial = int.Parse(txtGetPrimerParcial.Text);
                                    calificaciones.SegundoParcial = int.Parse(txtGetSegundoParcial.Text);
                                    calificaciones.TercerParcial = int.Parse(txtGetTercerParcial.Text);
                                    calificaciones.CuartoParcial = int.Parse(txtGetCuartoParcial.Text);
                                    calificaciones.PrimerLab = int.Parse(txtGetPrimerLab.Text);
                                    calificaciones.SegundoLab = int.Parse(txtGetSegundoLab.Text);
                                    calificaciones.TercerLab = int.Parse(txtGetTercerLab.Text);
                                    calificaciones.CuartoLab = int.Parse(txtGetCuartoLab.Text);

                                    float promedioComputo1 = ((int.Parse(txtGetPrimerParcial.Text)) * 0.15f) + ((int.Parse(txtGetPrimerLab.Text)) * 0.1f);
                                    float promedioComputo2 = ((int.Parse(txtGetSegundoParcial.Text)) * 0.15f) + ((int.Parse(txtGetSegundoLab.Text)) * 0.1f);
                                    float promedioComputo3 = ((int.Parse(txtGetTercerParcial.Text)) * 0.15f) + ((int.Parse(txtGetTercerLab.Text)) * 0.1f);
                                    float promedioComputo4 = ((int.Parse(txtGetCuartoParcial.Text)) * 0.15f) + ((int.Parse(txtGetCuartoLab.Text)) * 0.1f);


                                    float promedio = (promedioComputo1 + promedioComputo2 + promedioComputo3 + promedioComputo4);
                                    promedio = (float)Math.Round(promedio, 2);
                                    calificaciones.Promedio = promedio/100;
                                    lstCalificaciones.Add(calificaciones);
                                }
                            }
                        } else {
                            MessageBox.Show("RELLENE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    } else {
                        MessageBox.Show("RELLENE TODOS LOS CAMPOS", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("ALUMNO NO ENCONTRADO", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbCarreras_SelectedValueChanged(object sender, EventArgs e) {

            string query = "Select NombreMateria FROM Materias";
            MySqlConnection connection = GenerateConnection.Connection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader dr = command.ExecuteReader();

            try {
                if (dr.HasRows) {
                    while (dr.Read()) {
                        cmbMaterias.Items.Add(dr.GetString("NombreMateria"));
                    }
                } else {
                    MessageBox.Show("No hay materias disponibles");
                    return;
                }
            }catch(Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            } finally {
                dr.Close();
                connection.Close();
            }
        }
    }
}
