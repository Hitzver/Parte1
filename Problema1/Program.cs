using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChangeString chg = new ChangeString();
            Console.WriteLine("Ingrese una palabra");
            var variable = Console.ReadLine();
            var palabra = chg.Build(variable);
            
            Console.WriteLine("RESULTADO:  " + palabra);
            Console.ReadLine();
        }
    }
}
