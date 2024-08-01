using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Estudiante:Persona
    {
        private string carnet;

        //Crear el constructor
        public Estudiante()
        {
        }

        //Crear el constructor con parámetros
        public Estudiante(string nombre, string apellido1,
            string apellido2, string identificacion, int edad, string carnet)
            : base(nombre, apellido1, apellido2, identificacion, edad)
        {
            this.carnet = carnet;
        }
        //Metodos get y set de los atributos de la clase estudiante
        public void setCarnet(string carnet)
        {
            this.carnet = carnet;
        }
        public string getCarnet() 
        {
            return carnet;
         }

        //Metodos aplicando polimorfismo se utiliza new para que reemplace
        //el metodo de la clase Persona
        public new void Soy()
        {
            Console.WriteLine("Soy una persona estudiante y me llamo {0}", getNombre());
        }

        public override void Soy2()
        {
            Console.WriteLine("Soy un estudiante muy aplicado");
        }

    }
}
