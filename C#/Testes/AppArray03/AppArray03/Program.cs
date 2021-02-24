using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// App clonando um array
namespace AppArray03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sorteio = { 111, 222, 333, 444, 555, 666, 777 };

            // usando a clonagem de Array
            int[] copia_sorteio = (int[])sorteio.Clone();

            int conta = 0;
            foreach (int ind_copia_sorteio in copia_sorteio)
            {
                Console.WriteLine("Elemento {0} contem:{1}", conta.ToString(), ind_copia_sorteio.ToString());
                conta++;
            }

        }
    }
}
