using System;

namespace FilledSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSquare(n);
        }

        static void PrintBorderRow(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }

        static void PrintMiddle(int n)
        {
            Console.WriteLine("-{0}-", new string('/', n-1));
        }

        private static void PrintSquare(int number)
        {
            PrintBorderRow(number);

            for (int i = 0; i < number - 2; i++)
            {
                PrintMiddle(number);
            }

            PrintBorderRow(number);
        }
    }
}
