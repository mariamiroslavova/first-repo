using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_1
{
    class Program
    {
        static void Main(string[] args)
        {
            { 
             double n = double.Parse(Console.ReadLine());
                Console.Write("\\");
                for (int i = 1; i <= n; i++)

                {
                    Console.Write("*");

                }
                Console.Write("/");
            }
        }
    }
}
