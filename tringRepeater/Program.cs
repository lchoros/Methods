using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringRepeater
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = RepeatString(word, n);
            Console.WriteLine(result);
        }

        static string RepeatString(string word, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result += word;
            }
            return result;
        }
    }
}
