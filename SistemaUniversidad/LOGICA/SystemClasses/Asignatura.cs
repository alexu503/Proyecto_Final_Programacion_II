using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversidad.LOGICA
{
    public class Asignatura{

        public string NombreMateria { get; set; }
        public string HorasClase { get; set; }
        public string Carrera { get; set; }
        public float PrimerParcial { get; set; }
        public float PrimerLaboratorio { get; set; }
        public float SegundoParcial { get; set; }
        public float SegundoLaboratorio { get; set; }
        public float TercerParcial { get; set; }
        public float TercerLaboratorio { get; set; }
        public float CuartoParcial { get; set; }
        public float CuartoLaboratorio { get; set; }
        public float PromedioFinal { get; set; }

    }
}
