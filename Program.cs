using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {

            double num, resto;

            Console.Write("Olá usuário! Por favor digite um número: ");

            num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            resto = num % 2;

            /*Console.WriteLine(resto);
            Console.WriteLine();*/

            if(resto == 0)
            {
                Console.Write($"O número {num} é: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("par");
                Console.ResetColor();
                Console.WriteLine(".");
            }
            else
            {
                Console.Write($"O número {num} é: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("impar");
                Console.ResetColor();
                Console.WriteLine(".");             
            }

        }
    }
}
