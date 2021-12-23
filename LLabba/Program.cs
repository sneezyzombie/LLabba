using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLabba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            double x, y;

            a = Console.ReadLine();
            b = Console.ReadLine();

            double.TryParse(a, out x);
            double.TryParse(b, out y);

            Console.WriteLine("summ: " + (x + y));
            Console.WriteLine("difference: " + (x - y));
            Console.WriteLine("result of multiplication: " + (x * y));
            Console.WriteLine("result of division: " + (x / y));
            
        }
    }
}
