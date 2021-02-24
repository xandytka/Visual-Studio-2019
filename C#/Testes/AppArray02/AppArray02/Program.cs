using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//copiando e clonando strings
namespace AppArray02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sorteio = { 111, 222, 333, 444, 555, 666, 777 };
            int[] copia_sorteio = new int[sorteio.Length];

            // Usando metodo CopyTo
            sorteio.CopyTo(copia_sorteio, 0);

            int conta = 0;
            foreach (int ind_copia_sorteio in copia_sorteio)
            {
                Console.WriteLine("Elemento {0} contem:{1}", conta.ToString(), ind_copia_sorteio.ToString());
                conta++;
            }





        }
    }
}
