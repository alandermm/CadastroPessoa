using System;

namespace CadastroPessoa
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Qual é o seu nome?");
           string nome = Console.ReadLine(); 

           Console.WriteLine("RG:");
           string rg = Console.ReadLine(); 

           Console.WriteLine("CPF:");
           string cpf = Console.ReadLine(); 

           Console.WriteLine("Idade:");
           string idade = Console.ReadLine();

           Console.WriteLine("Gênero:");
           string genero = Console.ReadLine();

           Console.WriteLine("Estado civil:");
           string estado_civil = Console.ReadLine();

           Console.WriteLine("Profissão:");
           string profissao = Console.ReadLine();

           Console.WriteLine("Local de Nascimento:");
           string local_nascimento = Console.ReadLine();

           Console.WriteLine("Endereço:");
           string endereco = Console.ReadLine();

           Console.WriteLine("Cidade:");
           string cidade = Console.ReadLine();

           Console.WriteLine("Nome: " + nome + ", RG: " + rg + ", CPF: " + cpf);
           Console.WriteLine("Idade: " + idade + ", Gênero: " + genero + ", Estado Civil: " + estado_civil);
           Console.WriteLine("Profissao: " + profissao + ", Local de Nascimento: " + local_nascimento );
           Console.WriteLine("Endereço: " + endereco + ", Cidade: " + cidade);
        }
    }
}
