using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppArray01
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] nums_loteria;
            //nums_loteria = new int[6];

            int[] nums_sorteio = new int[6];
            int num;

            Console.WriteLine("Vamos preencher nosso array...");

          //for (int indice = 0; indice <= 5; indice++) 
            for (int indice = 0; indice < nums_sorteio.Length; indice++)
            {
                Console.WriteLine("Digite 0 (zero) para sair...");
                Console.WriteLine("Digite um numero para o array[{0}]:", indice.ToString());
                num = int.Parse(Console.ReadLine());
                if (num == 0)
                {
                    break;
                }
                nums_sorteio[indice] = num;

            }
                       
            Console.WriteLine("Impressao dos valores preenchidos no array sorteio:");
            /*
            //for (int listagem = 0; listagem <= 5; listagem++)
              for (int listagem = 0; listagem < nums_sorteio.Length; listagem++)
              {
                  Console.WriteLine("Valor preenchido no array[{0}] = {1}", listagem.ToString(), nums_sorteio[listagem].ToString());
              }
            */
            int listagem = 0;
            foreach (int NumIndice in nums_sorteio)
            {
                Console.WriteLine("Valor preenchido no array[{0}] = {1}", listagem.ToString(), NumIndice.ToString());
                listagem++;
            }
        }
    }
}
