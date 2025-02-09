
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Triangulo:Area
    {

        public void imprimir()
        {

            Console.Write("Ingrese la base del Triangulo: ");
            base1=Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese la altura del Triangulo: ");
            altura = Convert.ToDouble(Console.ReadLine());

            resultado=base1*altura;

            Console.WriteLine($"El area del Triangulo es {resultado}");
        }



    }
}
