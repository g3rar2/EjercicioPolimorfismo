using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Area
    {
        public double base1 { get; set; }
        public double altura {  get; set; }

        public double resultado { get; set; }

        public Area() { }

        public Area(double base1, double altura) 
        {
            this.base1 = base1;
            this.altura = altura;
        }


    }
}
