using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversidad.LOGICA.LogicalClasses {
    public class Proffessor: AcademicStaff {

        string name;
        string firstSurname;
        string secondSurname;
        string firstCareer;
        string secondCareer;

        public Proffessor() {
            //
        }

        public Proffessor(string n, string fsn, string ssn, string fc, string sc, string ssb) {
            name = n;
            firstSurname = fsn;
            secondSurname = ssn;
            firstCareer = fc;
            secondCareer = sc;
        }

        public override void AddNewStaff() {
            Name = name;
            FirstSurname = firstSurname;
            SecondSurname = secondSurname;
            CareerA = firstCareer;
            CareerB = secondCareer;
        }
    }
}
