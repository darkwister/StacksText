using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stacks.classes
{
    public class Palindromo
    {
        public static bool EsPalindromo(string palabra)
        {
            palabra = palabra.ToLower().Replace(" ", ""); 
            int inicio = 0, fin = palabra.Length - 1;

            while (inicio < fin)
            {
                if (palabra[inicio] != palabra[fin])
                    return false;
                inicio++;
                fin--;
            }

            return true;
        }
    }
}