using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int tempMin = GetMin(a, b);
            int min = GetMin(tempMin, c);
            Console.WriteLine(min);
        }

        static int GetMin(int a, int b)
        {
            if(a <= b)
            {
                return a;
            }
            return b;
        }
    }
}
