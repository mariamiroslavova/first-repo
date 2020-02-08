 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_2
{
    class Program
    {
     static void suma()
        {
            Console.WriteLine("Vuvedete chas");
            double h = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete min");
            double m = int.Parse(Console.ReadLine());
            Console.WriteLine("Vuvedete min");
            double s = int.Parse(Console.ReadLine());
            double sekundi = h * 3600 + m * 60 + s;
            double chasove = h + m/60+s/3600;
            Console.WriteLine("Vremeto v sekundi = "+sekundi);
            Console.WriteLine($"Vremeto v chasove = {chasove:f2}" );
        }
        static void Main(string[] args)
        {
            suma();
        }
    }
}
