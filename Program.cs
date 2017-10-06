using System;

namespace CadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Qual é o seu nome?");
           string nome = Console.ReadLine(); 

           Console.WriteLine("Qual é o seu RG?");
           string rg = Console.ReadLine(); 

           Console.WriteLine("Qual é o seu CPF?");
           string cpf = Console.ReadLine(); 

           Console.WriteLine("Qual é a sua idade?");
           int idade = Console.ReadLine();

           Console.WriteLine("Qual é o seu gênero?");
           string genero = Console.ReadLine(); 
        }
    }
}
