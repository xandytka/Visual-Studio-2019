using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repeticao05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            while(true)
            {
                Console.WriteLine("Para sair digite 0 (zero)...");
                Console.WriteLine("Digite um numero:");
                num = int.Parse(Console.ReadLine());

              //if ((num % 2) > 0)
                if (Convert.ToBoolean(num % 2))
                {
                    continue;
                }
                else
                {
                    if (num == 0)
                    {
                        Console.WriteLine("Fim de programa");
                        break;
                    }
                    Console.WriteLine("Ecoando somente numeros pares: {0}", num);
                }
            }
        }
    }
}
