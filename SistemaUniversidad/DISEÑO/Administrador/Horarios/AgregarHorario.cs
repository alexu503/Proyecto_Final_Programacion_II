using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaUniversidad.DISEÑO.Administrador.Horarios {
    public partial class AgregarHorario : Form {
        public AgregarHorario() {
            InitializeComponent();
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AgregarHorario_Load(object sender, EventArgs e) {
            this.LoadCarrersToCmb();
        }

        private void cmbGetCareerList_SelectedValueChanged(object sender, EventArgs e) {
            this.LoadSubjects(cmbGetCareerList.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e) {
            //
        }
    }
}
