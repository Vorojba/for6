using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 15, b = 30;
            double i, z;
            for (i = a; i <= b; i++)
            {
                z = 1.8 * i + 32;
                Console.WriteLine($"C={i}   f={z}");
            }
            Console.ReadKey();

        }
    }
}
