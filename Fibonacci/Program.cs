using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i< 15; i++)
            {
                if (IsFibonacci(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
        static public bool IsFibonacci(int i)
        {
            return Fibonacci().Contains(i);
        }

        static public List<int> Fibonacci()
        {
            List<int> fibonacci = new List<int>();
            int ultimo = 0;

            

            int penultimo = 0;
            for (int i = 0; ultimo < 350; i++)
            {
                if (i <= 1)
                {
                    fibonacci.Add(i);
                    ultimo = i;
                }
                else
                {
                    if ((ultimo + penultimo) < 350)
                    {
                        fibonacci.Add(ultimo + penultimo);
                        int tempUltimo = ultimo + penultimo;
                        penultimo = ultimo;
                        ultimo = tempUltimo;
                    }
                }
            }
            return fibonacci;
        }
    }
}
