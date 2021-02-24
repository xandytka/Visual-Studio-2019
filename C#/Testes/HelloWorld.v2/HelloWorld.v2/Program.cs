using System;

namespace HelloWorld.v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nQual o seu nome?");
            var name = Console.ReadLine();
            var date = DateTime.Now;
            Console.WriteLine($"\nOlá, {name}, neste {date:d} ás {date:t}!");
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey(true);
        }
    }
}
