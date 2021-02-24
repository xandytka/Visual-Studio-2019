using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppMostrarNome
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int idade;

            Console.WriteLine("Qual seu nome?");
            nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Olá {0}! Sua idade é:{1}", nome, idade.ToString());
        }
    }
}
