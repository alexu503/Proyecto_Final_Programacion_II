using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SistemaUniversidad.LOGICA {
    internal class BotonesPnlSuperior {
        public void Maximizar(Form edit, object sender, EventArgs e, Button btnMaximizar, Button btnRestaurar) {
            edit.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }
        public void Restaurar(Form edit, object sender, EventArgs e, Button btnRestaurar, Button btnMaximizar) {
            edit.WindowState=FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible=true;
        }
        public void Minimizar(Form edit, object sender, EventArgs e) {
            edit.WindowState = FormWindowState.Minimized;
        }
        //----> EL BOTÓN DE "Cerrar" NO FUE PROGRAMADO PORQUE SE HARÁ CREANDO UN OBJETO DE TIPO "Login" Y LLAMANDO
        //----  LA FUNCION "VolverIncio" CON EL FIN DE REUTILIZAR CODIGO
        public BotonesPnlSuperior() {

        }
    }
}
