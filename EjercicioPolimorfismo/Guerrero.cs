using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    public class Guerrero
    {
        public string categoria {  get; set; }
        public string estrella { get; set; }

        public Guerrero() { }

        public Guerrero(string categoria, string estrella)
        {
            this.categoria = categoria;
            this.estrella = estrella;
        }

        public void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"El guerrero es categoria {categoria}, bajo la estrella {estrella}");
        }


    }
}
