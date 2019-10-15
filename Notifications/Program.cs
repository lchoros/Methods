using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notifications
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static string ShowSuccess(string operation, string mesage)
        {
            return $"Successfully executed {operation}.";
        }

        static string ShowError(string operation, int code)
        {
            return $"Error: Failed to execute {operation}.";
        }
    }
}
