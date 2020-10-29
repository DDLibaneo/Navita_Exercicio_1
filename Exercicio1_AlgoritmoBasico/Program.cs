﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1_AlgoritmoBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApplication = false;            

            while (!endApplication)
            {
                Console.WriteLine("Insira um numero inteiro.");

                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out int value);

                if (parseSuccess)
                {
                    int result = BrotherNumberService.LargestNumberOnNFamily(value);
                    Console.WriteLine($"O maior numero na familia N do numero {value} é {result}.");
                }
                else
                {
                    Console.WriteLine("Numero inteiro iválido.");
                }

                Console.WriteLine("Aperte qualquer tecla para recomeçar, ESC para encerrar a aplicação.");

                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    return;
            }
        }
    }
}
