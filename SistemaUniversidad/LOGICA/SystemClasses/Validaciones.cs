using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using SistemaUniversidad.DISEÑO;

namespace SistemaUniversidad.LOGICA
{
    internal class Validaciones
    {
        //Valida números flotantes (con punto) al igual que números de celular (con un guíon "-")
        public void ValidarDigitos(object sender, KeyPressEventArgs e, Label lblMensaje1)
        {
            if (true != char.IsDigit(e.KeyChar) && true != char.IsControl(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
                lblMensaje1.ForeColor = Color.Red;
                lblMensaje1.Text = "Dato no válido";
            }
            else
            {
                e.Handled = false;
                lblMensaje1.Text = "";
            }
        }

        //Valida letras (con espacios) ayuda para los nombres y apellidos
        public void ValidarLetras(object sender, KeyPressEventArgs e, Label lblMensaje1)
        {
            if (true != char.IsControl(e.KeyChar) && true != char.IsLetter(e.KeyChar) &&  e.KeyChar != ' ')
            {
                e.Handled = true;
                lblMensaje1.ForeColor = Color.Red;
                lblMensaje1.Text = "Dato no válido";
            }
            else
            {
                e.Handled = false;
                lblMensaje1.Text = "";
            }
        }
        
        //Valida que NO sean espacios vacíos
        public void ValidarEspacios(object sender, KeyPressEventArgs e, Label lblMensaje1)
        {
            if(e.KeyChar == ' ')
            {
                e.Handled = true;
                lblMensaje1.ForeColor = Color.Red;
                lblMensaje1.Text = "Dato no válido";
            }
            else
            {
                e.Handled = false;
                lblMensaje1.Text = "";
            }
        }

        //Valida que la fecha de nacimiento sea distinta a la fecha actual
        public void ValidarFechaNacimiento(DateTime nacimiento)
        {
            DateTime FechaActual = DateTime.Today;
            FechaActual.ToShortDateString();
        }

        //Valida que las entradas sean letras y números pero NO símbolos ó espacios ó puntos
        public void ValidarLetrasNumero(object sender, KeyPressEventArgs e, Label lblMensaje1)
        {
            if (true != char.IsDigit(e.KeyChar) && true != char.IsControl(e.KeyChar) && true != char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                lblMensaje1.ForeColor = Color.Red;
                lblMensaje1.Text = "Dato no válido";
            }
            else
            {
                e.Handled = false;
                lblMensaje1.Text = "";
            }
        }
    }
}
