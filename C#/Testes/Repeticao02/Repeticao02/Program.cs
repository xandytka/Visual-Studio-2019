using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repeticao02
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            nome = "inicio..";
                       
            while(nome != "fim")
            {
                Console.WriteLine("Digite um nome ou digite fim para sair.");
                nome = Console.ReadLine();
                Console.WriteLine(nome);
            }
        }
    }
}
