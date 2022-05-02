using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_a_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double radius = 0;
            //if (args.Length > 0)
            //{
            //    radius = Convert.ToDouble(args[0]);
            //}
            //Console.WriteLine(radius * radius * pi);
            radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(radius * radius * pi);
            Console.ReadKey();
        }
    }
}
