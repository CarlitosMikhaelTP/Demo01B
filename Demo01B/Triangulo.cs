using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    public class Triangulo
    {
        public int x1 { get; set; }
        public int  y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }
        public int x3 { get; set; }
        public int y3 { get; set; }
        public int perimetro { get; set; }
        public int area { get; set; }

        // Math.Sqrt
        // Math.Paw(valor,2)
        public string CalcularPerimetroArea(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            
            // Hallando el primer lado
            double valorPrimerlado;
            valorPrimerlado = Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)));

            // Hallando el segundo lado
            double valorSegundoLado;
            valorSegundoLado = Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)));

            // Hallando el tercer lado
            double valorTercerLado;
            valorTercerLado = Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)));

            // Calculando el perímetro
            double perimetro;
            perimetro = valorPrimerlado + valorSegundoLado + valorTercerLado;

            // Calculando el semiperimetro
            double semiperimetro;
            semiperimetro = perimetro / 2;

            // Calculado el área
            double area;
            area = Math.Sqrt(semiperimetro * (semiperimetro - valorPrimerlado) * (semiperimetro - valorSegundoLado) * (semiperimetro - valorTercerLado));

            // Personalizando el mensaje de salida
            string mensaje = "El Perimetro es: " + perimetro + "\ny el Área es: " + area;
            // Devolviendo valores
            return mensaje;
            

        }
        public int CalcularPerimetro()
        {
            return 3;
        }

        public int CalcularAreao()
        {
            return 3;
        }


    }
}
