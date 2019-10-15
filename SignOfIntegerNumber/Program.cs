﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOfIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        static void PrintSign(int number)
        {
            if(number == 0)
            {
                Console.WriteLine("The number 0 is zero");
            }
            else if(number < 0)
            {
                Console.WriteLine("The number {0} is negative", number);
            }
            else
            {
                Console.WriteLine("The number {0} is positive", number);
            }
        }
    }
}
