using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante est1 = new Estudiante();
            est1.setNombre("Fabiola");
            est1.setApellido1("Robles");
            est1.setApellido2("Vindas");
            est1.setEdad(40);
            est1.setIdentificacion("12132");
            est1.setCarnet("1111");

            est1.Presentacion();
            est1.Soy();
            est1.Soy2();
            
            //Crear una instancia de profesor
            Profesor profe = new Profesor("Idiomas","Lic","Luis","Alfaro","Roque","23434",34);
            profe.Presentacion();
            profe.Soy();
            profe.Soy2();
            Console.ReadKey();


        }
    }
}
