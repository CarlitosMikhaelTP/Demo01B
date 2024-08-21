using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Profesor profesor = new Profesor();
            //Console.WriteLine(profesor.CalcularSueldoNeto(5200));
            //Console.Read();

            Triangulo triangulo = new Triangulo();
            Console.WriteLine(triangulo.CalcularPerimetroArea(15, 20, 33, 45, 60, 92));
            Console.Read();

            /* Persona persona = new Persona();
             persona.Nombre = "Carlitos";
             persona.Apellido = "Torres";*/

            /* Persona persona2 = new Persona("Mikhael", "Pérez");

             Persona persona3 = new Persona
             {
                 Nombre = "Michael",
                 Apellido = "Salazar",
                 Edad = 2
             };*/
            //persona.AsignarNombresCompletos();
            /*Triangulo triangulo = new Triangulo();
            triangulo.Base = 7;
            triangulo.Altura = 8;*/


            //Console.WriteLine(persona.NombresCompletos);
            /* Console.WriteLine(triangulo.CalcularArea());
             Console.Read();

             Estudiante estudiante = new Estudiante()
             {
                 Nombre = "Juan",
                 Apellido = "De la Llama",
                 Nota = 20
             };*/


        }
    }
}
