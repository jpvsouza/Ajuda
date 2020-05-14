using System;
using System.Collections.Generic;

namespace Anotacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadee = 30;
            //converte para string usando tostring
            string idadeNoString = idadee.ToString();
            //converte para string usando convert
            decimal idadeNoStringDeOutraForma = Convert.ToDecimal("10,5");

            //Faz conversao da palavra morango e a palavra 15 pra int
            //Melhor usar try do que convert porque o try nao gera excecao
            int.TryParse("morango", out int varIntTry);
            int.TryParse("15", out int varIntTry1);

            int.TryParse(Console.ReadLine(), out int idade);
            if(idade<12)
            {
                Console.WriteLine($"Voce escreveu a idade {idade}");
            }

            //if e else so pode usar um por estrutura mas o else if pode usar varios

            string mensagem = idade >= 18 ? "de maior" : "de menor";

            var sexo = Console.ReadLine();
            switch(sexo.ToLower())

            {
                case "masculino":
                    Console.WriteLine("Homem");
                    break;
                case "feminino":
                    Console.WriteLine("Mulher");
                    break;
                default:
                    Console.WriteLine("Genero estranho");
                    break;
                   
            }

            //array tem que definir o tamanho
            string[] nomes = new string[5];
            nomes[0] = "Ana";

            //list nao tem que definir o tamanho
            List<string> sobrenomes = new List<string>();
            sobrenomes.Add("Lucia");
        
            //Loops
            for(int i = 0; i<sobrenomes.Count; i++)
            {
                Console.WriteLine($"Sobrenome {i + 1}:{sobrenomes[i]}");
            }

            foreach (string sobrenome in sobrenomes)
            {
                Console.WriteLine($"Sobrenome por foreach: {sobrenome}");
            }

            int x = sobrenomes.Count - 1;
            while (x>=0)
            {
                Console.WriteLine($"Sobrenomes no while: {sobrenomes[x]}");
                x--;
            }
        }
    }
}
