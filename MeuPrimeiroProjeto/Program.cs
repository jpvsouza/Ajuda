using System;

namespace MeuPrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operadores aritmeticos
            var soma = 10 + 5;
            var subtracao = 10 - 5;
            var multiplicacao = 10 * 5;
            var divisao = 10 / 5;
            var mod = 10 % 5;
            
            Console.WriteLine($"Resultado da soma: {soma}");
            Console.WriteLine($"Resultado da subtracao: {subtracao}");
            Console.WriteLine($"Resultado da soma: {multiplicacao}");
            Console.WriteLine($"Resultado da soma: {divisao}");
            Console.WriteLine($"Resultado do resto: {mod}");

            //Operadores logicos
            var everdadeiro = true && true;
            var efalso1 = true && false;
            var efalso2 = false && true;
            var efalso3 = false && false;

            var ouverdadeiro = true || true;
            var ouverdadeiro1 = false || true;
            var ouverdadeiro2 = true || false;
            var oufalso = false || false;

            Console.WriteLine(everdadeiro);
            Console.WriteLine(efalso1);
            Console.WriteLine(efalso2);
            Console.WriteLine(efalso3);

            var falsonegado = !false;
            var verdadeironegado = !true;

            Console.WriteLine(falsonegado);
            Console.WriteLine(verdadeironegado);



        }
    }
}
