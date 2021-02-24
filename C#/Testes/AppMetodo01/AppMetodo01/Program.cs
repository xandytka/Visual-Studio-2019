using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppMetodo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor01, valor02, soma;
            Console.WriteLine("Digite um numero:");
            valor01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero:");
            valor02 = int.Parse(Console.ReadLine());

            soma = soma_numeros(valor01, valor02);
            Console.WriteLine("Resulta da soma é: {0}", soma);
        }
        static int soma_numeros(int num01, int num02)
        {
            int resultado = num01 + num02;
            return resultado;
        }
    }
}
