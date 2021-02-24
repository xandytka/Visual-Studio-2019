using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppMetodo02
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            quadrado(numero);
        }
        public static void quadrado(int num)
        {
            num *= num;
            Console.WriteLine("O quadrado do numero digitado é: {0}", num.ToString());
        }
    }
}
