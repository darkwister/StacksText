using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stacks.classes
{
    public class ExpresionMatematica
    {
        public static bool EstaBalanceada(string expresion)
        {
            Stack<char> pila = new();

            foreach (char c in expresion)
            {
                if (c == '(')
                    pila.Push(c);
                else if (c == ')')
                {
                    if (pila.Count == 0)
                        return false;
                    pila.Pop();
                }
            }

            return pila.Count == 0;
        }
    }
}