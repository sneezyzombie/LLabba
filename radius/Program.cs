using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string var;
            double r;

            var = Console.ReadLine();
            double.TryParse(var, out r);

            Console.WriteLine("lenght: " + (2 * 3.14 * r));
            Console.WriteLine("s: " + (3.14 * r * r));
        }
    }
}
