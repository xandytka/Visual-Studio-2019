using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDiaSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            int DiaSemana;

            Console.WriteLine("Digite o dia da semana de 1-7...");
            DiaSemana = int.Parse(Console.ReadLine());

            switch(DiaSemana)
            {
                case 1:
                    Console.WriteLine("O dia é escolhido é: domingo.");
                    break;
                case 2:
                    Console.WriteLine("O dia é escolhido é: segunda-feira.");
                    break;
                case 3:
                    Console.WriteLine("O dia é escolhido é: terça-feira.");
                    break;
                case 4:
                    Console.WriteLine("O dia é escolhido é: quarta-feira.");
                    break;
                case 5:
                    Console.WriteLine("O dia é escolhido é: quinta-feira.");
                    break;
                case 6:
                    Console.WriteLine("O dia é escolhido é: sexta-feira.");
                    break;
                case 7:
                    Console.WriteLine("O dia é escolhido é: sabado-feira.");
                    break;
                default:
                    Console.WriteLine("O dia escolhido invalido.");
                    break;

            }
        }
    }
}
