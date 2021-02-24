using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repeticao04
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;

            do
            {
                Console.WriteLine("Digite um nome ou digite fim para sair.");
                nome = Console.ReadLine();
                Console.WriteLine(nome);
            }
            while (nome != "fim");
        }
    }
}
