using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double bottom = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTriangleArea(bottom, height);
            Console.WriteLine(area);
        }

        static double GetTriangleArea(double bottom, double height)
        {
            return bottom * height / 2;
        }
    }
}
