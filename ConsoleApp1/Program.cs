using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, D, y;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            D = b * b - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("Корней нет");
            }
            else if (D == 0)
            {
                x = -b/(2 * a);
                Console.WriteLine("X="+x);
            }
            Console.ReadLine();
        }
    }
}