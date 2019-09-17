using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z, r;
            Console.WriteLine("Vvedite x:");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite y:");
            y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite z:");
            z = Convert.ToDouble(Console.ReadLine());
            r = (2 * Math.Cos(x * x) - 1/2.0) / (1/2.0 + Math.Sin(Math.Pow(y, (2 - z)))) + z * z / (7 - (z / 3));
            Console.WriteLine(r);
        }
    }
}
