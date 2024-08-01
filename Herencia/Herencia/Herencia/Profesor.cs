using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Profesor:Persona
    {
        protected string especialidad;
        protected string gradoAcademico;

        public void setEspecialidad(string especialidad)
        {
            this.especialidad = especialidad;
        }
        public string getEspecialidad() 
        {
            return especialidad;
        }

        public void setGradoAcademico(string gradoAcademico)
        {
            this.gradoAcademico = gradoAcademico;
        }

        public string getGradoAcademico() 
        { 
            return gradoAcademico; 
        }

        public Profesor()
        {
        }

        public Profesor(string especialidad, string gradoAcademico,string nombre, 
            string apellido1,string apellido2,string identificacion,int edad)
            :base(nombre,apellido1,apellido2,identificacion,edad)
        {
            this.especialidad = especialidad;
            this.gradoAcademico = gradoAcademico;
        }

        //Metodos aplicando polimorfismo se utiliza new para que reemplace
        //el metodo de la clase Persona
        public new void Soy()
        {
            Console.WriteLine("Soy un profesor y me llamo {0}", getNombre());
        }
        public override void Soy2()
        {
            Console.WriteLine("Soy un profesor muy responsable");
        }

    }
}
