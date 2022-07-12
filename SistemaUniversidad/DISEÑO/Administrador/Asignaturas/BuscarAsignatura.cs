using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUniversidad.DISEÑO.Administrador.Asignaturas {
    public partial class BuscarAsignatura : Form {
        public BuscarAsignatura() {
            InitializeComponent();
            this.LoadCarrersToCmb();
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cmbCarreras_TextUpdate(object sender, EventArgs e) {
            if(cmbCarreras.Text != "Seleccionar") {
                string selectedCareer = cmbCarreras.Text;
                this.LoadSubjectsToCMB(ref selectedCareer);
            } else {
                cmbGetSubjects.Text = "Seleccionar";
            }
        }

        private void btnLoad_Click(object sender, EventArgs e) {
            if (cmbCarreras.Text != "Seleccionar" && cmbGetSubjects.Text != "Seleccionar") {

            } else {
                MessageBox.Show("Seleccione los campos requeridos");
            }
        }
    }
}
