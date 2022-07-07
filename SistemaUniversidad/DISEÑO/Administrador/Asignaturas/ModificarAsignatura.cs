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
    public partial class ModificarAsignatura : Form {
        public ModificarAsignatura() {
            InitializeComponent();
        }

        private void btnReturnToMainForm_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
