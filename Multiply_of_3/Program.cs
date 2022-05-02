using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * https://www.sololearn.com/learning/eom-project/1080/1017
 */
namespace Multiply_of_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0) Console.Write("*");
                else Console.Write(i);
            }
            Console.ReadKey();
        }
    }
}
