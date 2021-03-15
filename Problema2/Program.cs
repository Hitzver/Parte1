using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderRange ord = new OrderRange();
            Console.WriteLine("Cadena de prueba ingresada. Ejemplo: 1,2,3,4,5,6");
            int[] numeros = new[] {1, 2, 3, 4, 5, 6};

            string cadena = ord.Build(numeros);

            Console.WriteLine("Cadenas: ");
            Console.WriteLine(cadena);
            Console.ReadKey();
            return;
        }
    }
}
