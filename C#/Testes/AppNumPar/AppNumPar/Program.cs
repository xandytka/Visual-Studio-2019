using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppNumPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Digite o primeiro numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero:");
            num2 = int.Parse(Console.ReadLine());

            if ((num1 % 2) > 0)
            {
                Console.WriteLine("O primeiro numero é impar");
            }
            else
            {
                Console.WriteLine("O primeiro numero é par");
            }

            if ((num2 % 2) > 0)
            {
                Console.WriteLine("O segundo numero é impar");
            }
            else
            {
                Console.WriteLine("O segundo numero é par");
            }

            if(num1 > num2)
            {
                Console.WriteLine("O primeiro numero é maior que o segundo numero");
            }
            else if((num1 < num2))
            {
                Console.WriteLine("O segundo numero é maior que o primeiro numero");
            }
            else
            {
                Console.WriteLine("O primeiro e segundo numero são iguais");
            }

        }
    }
}
