using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema2
{
    public class OrderRange
    {
        public string Build(int[] numeros)
        {
            string cadena;

            List<int> Par = new List<int>();
            List<int> Impar = new List<int>();

            int first = numeros[0];

            foreach (int num in numeros)
            {
                if(Convert.ToInt32(num) % 2 == 0)
                {
                    Par.Add(num);
                }
                else
                {
                    Impar.Add(num);
                }
            }

            if (Convert.ToInt32(first) % 2 == 0)
            {
                cadena = string.Join(", ", Par.ToArray()) + " | " +string.Join(", ", Impar.ToArray());
            }
            else
            {
                cadena = string.Join(", ", Impar.ToArray()) + " | " + string.Join(", ", Par.ToArray());
            }

            return cadena;
        }
    }

}
