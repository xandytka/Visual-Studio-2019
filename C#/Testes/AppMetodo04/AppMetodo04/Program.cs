using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// sobrecarga de metodo
namespace AppMetodo04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_int = 2;
            float numero_float = 3_00.5F;
            double numero_double = 12.3;

            incrementa(ref numero_double);
        
        }
        public static void incrementa(ref int num)
        {
            num++;
            Console.WriteLine("O incrementa do numero digitado é: {0}", num.ToString());
        }
        public static void incrementa(ref float num)
        {
            num++;
            Console.WriteLine("O incrementa do numero digitado é: {0}", num.ToString());
        }
        public static void incrementa(ref double num)
        {
            num++;
            Console.WriteLine("O incrementa do numero digitado é: {0}", num.ToString());
        }

    }
}
