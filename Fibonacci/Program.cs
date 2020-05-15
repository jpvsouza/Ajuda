using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        public List<int> Fibonacci()
        {
            List<int> Fibonacci = new List<int>();
            int ultimo = 0;

            int penultimo = 0;
            for (int i = 0; ultimo < 350; i++)
            {
                if (i <= 1)
                {
                    Fibonacci.Add(i);
                    ultimo = i;
                }
                else
                {
                    if ((ultimo + penultimo) < 350)
                    {
                        Fibonacci.Add(ultimo + penultimo);
                        int tempUltimo = ultimo + penultimo;
                        penultimo = ultimo;
                        ultimo = tempUltimo;
                    }
                    else break;
                }
            }
            return Fibonacci;
        }
    }
}
