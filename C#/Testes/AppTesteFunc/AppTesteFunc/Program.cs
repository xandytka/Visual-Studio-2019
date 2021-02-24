using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomaNum;

namespace AppTesteFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor01, valor02, resultado;
            Console.WriteLine("Digite um numero: ");
            valor01 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            valor02 = int.Parse(Console.ReadLine());

            resultado = Somaqq.Soma(valor01, valor02);
            Console.WriteLine("Resultado: {0}", resultado);
            
        }
    }
}
