using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// metodo passagem por referencia
namespace AppMetodo03
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Digite um numero: ");
            numero = int.Parse(Console.ReadLine());
            incrementa(ref numero);
            Console.WriteLine("O incremento do numero digitado é: {0}", numero.ToString());

        }
        public static void incrementa(ref int num)
        {
            num ++;
        }
 
    }
}
