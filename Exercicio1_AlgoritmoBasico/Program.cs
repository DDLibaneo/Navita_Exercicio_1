using System;
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
            while (true)
            {
                Console.WriteLine("Insira um numero inteiro.");

                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out int value);

                if (parseSuccess)
                {
                    int result = BrotherNumberService.LargestNumberOnNFamily(value);
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("\nNumero inteiro inválido.");
                }

                Console.WriteLine("Aperte qualquer tecla para recomeçar, ESC para encerrar a aplicação.");

                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    return;

                Console.WriteLine("\n");
            }
        }
    }
}
