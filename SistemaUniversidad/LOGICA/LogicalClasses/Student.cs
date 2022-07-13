using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversidad.LOGICA.LogicalClasses{
    public class Student: AcademicStaff{

        private string name;
        private string firstSurname;
        private string secondSurname;
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

        public Student(string n, string fl1, string fl2, string c, string p, string b, string dni, string sex, string add, string ph, string mph, string e, string id, string cs, string nn) {
            name = n;
            firstSurname = fl1;
            secondSurname = fl2;
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
            Name = name;
            FirstSurname = firstSurname;
            SecondSurname = secondSurname;
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
            MaritalStatus = civilstate;
            Nationality = nationality;
        }
    }
}
