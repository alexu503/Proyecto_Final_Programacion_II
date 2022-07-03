using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversidad.LOGICA
{
    public class Student: AcademicStaff{

        private string name;
        private string firstLastname;
        private string career;
        private string passwrd;
        private string birthday;
        private string dnistudent;
        private string sexstudent;
        private string address;
        private string phone;
        private string mobilephone;
        private string email;
        private string inscriptiondate;
        private string civilstate;
        private string nationality;
        //private float[] notas;

        public Student(string n, string fl, string c, string p, string b, string dni, string sex, string add, string ph, string mph, string e, string id, string cs, string nn) {
            name = n;
            firstLastname = fl;
            career = c;
            passwrd = p;
            birthday = b;
            dnistudent = dni;
            sexstudent = sex;
            address = add;
            phone = ph;
            mobilephone = mph;
            email = e;
            inscriptiondate = id;
            civilstate = cs;
            nationality = nn;
        }

        public Student() {
            //
        }

        public override void AddNewStaff() {
            FirstName = this.name;
            Lastname = firstLastname;
            CareerA = career;
            Password = passwrd;
            BirthDate = birthday;
            DNI = dnistudent;
            Sex = sexstudent;
            Address = address;
            Phone = phone;
            MobilePhone = mobilephone;
            Email = email;
            InscriptionDate = inscriptiondate;
            CivilStatus = civilstate;
            Nationality = nationality;
        }
    }
}
