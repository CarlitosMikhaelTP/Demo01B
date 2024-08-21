using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Profesor : Persona
    {
        public double Sueldo { get; set; }

        public double CalcularSueldoNeto(double sueldo)
        {
            if (sueldo >= 0 & sueldo < 2000)
            {
                return sueldo - 0.08*sueldo;
            }
            else if (sueldo >= 2000 & sueldo < 5000)
            {
                return sueldo - 14 ;
            }
            else 
            {
                return sueldo - 30 ;
            }
        }
    }
}
