using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaUniversidad.LOGICA
{
    public class Alumno
    {
        private string nombres;
        private string primerApellido;
        private string segundoApellido;
        private string carnet;
        private string carrera;
        private string passwrd;
        private int matricula;
        private string fechaNacimiento;
        private string documentoIdentidad;
        private string sexo;
        private string direccion;
        private string telefono;
        private string celular;
        private string correo;
        private string fechaInscripcion;
        private string nacionalidad;
        private string estadoCivil;
        //private float[] notas;

        //Falta que incorporar algunos datos

        #region Métodos setters
        public void setNombres(string nombres)
        {
            this.nombres = nombres;
        }
        public void setPrimerApellido(string primerApellido)
        {
            this.primerApellido = primerApellido;
        }
        public void setSegundoApellido(string segundoApellido)
        {
            this.segundoApellido = segundoApellido;
        }
        public void setCarnet(string carnet)
        {
            this.carnet = carnet;
        }
        public void setPassword(string passwrd)
        {
            this.passwrd = passwrd;
        }
        public void setCarrera(string carrera)
        {
            this.carrera = carrera;
        }
        public void setMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public void setFechaNacimiento(string fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }
        public void setDocumentoIdentidad(string documentoIdentidad)
        {
            this.documentoIdentidad = documentoIdentidad;
        }
        public void setSexo(string sexo)
        {
            this.sexo = sexo;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public void setCelular(string celular)
        {
            this.celular = celular;
        }
        public void setCorreo(string correo)
        {
            this.correo = correo;
        }
        public void setFechaInscripcion(string fechaInscripcion)
        {
            this.fechaInscripcion = fechaInscripcion;
        }
        public void setNacionalidad(string nacionalidad)
        {
            this.nacionalidad = nacionalidad;
        }
        public void setEtadoCivil(string estadoCivil)
        {
            this.estadoCivil = estadoCivil;
        }
        #endregion

        #region Métodos getters
        public string getNombres()
        {
            return nombres;
        }
        public string getPrimerApellido()
        {
            return primerApellido;
        }
        public string getSegundoApellido()
        {
            return segundoApellido;
        }
        public string getCarnet()
        {
            return carnet;
        }
        public string getPasswrd()
        {
            return passwrd;
        }
        public string getCarrera()
        {
            return carrera;
        }
        public int getMatricula()
        {
            return matricula;
        }
        public string getFechaNacimiento()
        {
            return fechaNacimiento;
        }
        public string getDocumentoIdentidad()
        {
            return documentoIdentidad;
        }
        public string getSexo()
        {
            return sexo;
        }
        public string getDireccion()
        {
            return direccion;
        }
        public string getTelefono()
        {
            return telefono;
        }
        public string getCelular()
        {
            return celular;
        }
        public string getCorreo()
        {
            return correo;
        }
        public string getFechaInscripcion()
        {
            return fechaInscripcion;
        }
        public string getNacionalidad()
        {
            return nacionalidad;
        }
        public string getEstadoCivil()
        {
            return estadoCivil;
        }
        #endregion

        //#region Constructores
        //public Alumno()
        //{

        //}
        //#endregion

        //aa
    }
}
