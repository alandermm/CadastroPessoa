using System;
using System.Collections.Generic;

namespace CadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
           var pessoa = new Dictionary<string, string>();
           
           Console.WriteLine("Qual é o seu nome?");
           pessoa["Nome"] = Console.ReadLine(); 
           
           Console.WriteLine("RG:");
           pessoa["RG"] = Console.ReadLine(); 

           Console.WriteLine("CPF:");
           pessoa["CPF"] = Console.ReadLine(); 

           Console.WriteLine("Idade:");
           pessoa["Idade"] = Console.ReadLine();

           Console.WriteLine("Gênero:");
           pessoa["Gênero"] = Console.ReadLine();

           Console.WriteLine("Estado civil:");
           pessoa["Estado Civil"] = Console.ReadLine();

           Console.WriteLine("Profissão:");
           pessoa["Profissao"] = Console.ReadLine();

           Console.WriteLine("Local de Nascimento:");
           pessoa["Local de Nascimento"] = Console.ReadLine();

           Console.WriteLine("Endereço:");
           pessoa["Endereco"] = Console.ReadLine();

           Console.WriteLine("Cidade:");
           pessoa["Cidade"] = Console.ReadLine();

           Console.WriteLine("\n\n\n");
           foreach (var atributo in pessoa)
           {
               Console.WriteLine(atributo.Key + ": " + atributo.Value);
           }
        }
    }
}