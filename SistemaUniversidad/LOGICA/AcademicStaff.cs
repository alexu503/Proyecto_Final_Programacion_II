using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversidad.LOGICA {
    public abstract class AcademicStaff {

        public string FirstName{get; set;}
        public string Lastname { get; set; }
        public string CareerA { get; set; }
        public string CareerB { get; set; }
        public string Password { get; set; }
        public string DNI { get; set; }
        public string BirthDate { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string InscriptionDate { get; set; }
        public string CivilStatus { get; set; }
        public string Nationality { get; set; }

        public abstract void AddNewStaff();
    }
}
