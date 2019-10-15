using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathPowerExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double res = RaiseToPower(n, power);
            Console.WriteLine(res);

        }

        static double RaiseToPower(int n, int power)
        {
            double number = n;
            if(power == 0)
            {
                return 1;
            }

            for (int i = 1; i < power; i++)
            {
                number *= n;
            }
            return number;
        }
    }
}
