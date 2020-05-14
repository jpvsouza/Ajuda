using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Fibonacci = new List<int>();
            int ultimo = 0;
            
            int penultimo = 0;
            for (int i=0; i < 350; i++ )
            {
                if (i<=1)
                {
                    Fibonacci.Add(i);
                    ultimo = i;
                }
                else
                {
                    Fibonacci.Add(ultimo + penultimo);
                    int tempUltimo = ultimo + penultimo;
                    penultimo = ultimo;
                    ultimo = tempUltimo;
                }

            }
            foreach (int numero in Fibonacci)
            {
                Console.WriteLine(numero);
            }


        }
    }
}
