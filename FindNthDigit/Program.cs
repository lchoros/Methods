using System;

namespace FindNthDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine(FindNthDigit(number, index));
        }


        static int FindNthDigit(long number, int index)
        {
            int reminder = 0;
            for (int i = 0; i < index; i++)
            {
                reminder = (int)(number % 10);
                number /= 10;
            }
            return reminder;
        }
    }
}
