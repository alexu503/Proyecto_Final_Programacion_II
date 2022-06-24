using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversidad.LOGICA
{
    internal class Carrera
    {
        private string nombre;
        //private int coidigoCarrera;

        #region Métodos setters
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        //public void setCodigoCarrera(int codigoCarrera)
        //{
        //    this.codi
        //}
        #endregion

        #region Métodos getters
        public string getNombre()
        {
            return nombre;
        }
        #endregion
    }
}
