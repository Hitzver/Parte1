using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    public class ChangeString
    {
        public string Build(string palabra)
        {
            Dictionary<int, string> abc = ObtenerAbecedario();

            string nuevaPalabra = string.Empty;

            foreach (char letra in palabra)
            {
                if (!char.IsNumber(letra))
                {
                    var num = abc.FirstOrDefault(x => x.Value == letra.ToString()).Key + 1;
                    var letraCamio = abc.FirstOrDefault(x => x.Key == num).Value;
                    var letraOrigen = letra.ToString();
                    nuevaPalabra = nuevaPalabra + letraOrigen.Replace(letraOrigen, letraCamio);
                }
                else
                {
                    nuevaPalabra = nuevaPalabra + letra.ToString();
                }

                
            }

            return nuevaPalabra;
        }

        private Dictionary<int, string> ObtenerAbecedario()
        {
            Dictionary<int, string> abc = new Dictionary<int, string>();

            abc.Add(1, "a");
            abc.Add(2, "b");
            abc.Add(3, "c");
            abc.Add(4, "d");
            abc.Add(5, "e");
            abc.Add(6, "f");
            abc.Add(7, "g");
            abc.Add(8, "h");
            abc.Add(9, "i");
            abc.Add(10, "j");
            abc.Add(11, "k");
            abc.Add(12, "l");
            abc.Add(13, "m");
            abc.Add(14, "n");
            abc.Add(15, "ñ");
            abc.Add(16, "o");
            abc.Add(17, "p");
            abc.Add(18, "q");
            abc.Add(19, "r");
            abc.Add(20, "s");
            abc.Add(21, "t");
            abc.Add(22, "u");
            abc.Add(23, "v");
            abc.Add(24, "w");
            abc.Add(25, "x");
            abc.Add(26, "y");
            abc.Add(27, "z");

            return abc;
        }
    }
}
