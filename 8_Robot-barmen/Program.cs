using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * https://www.sololearn.com/learning/eom-project/1080/1053
 */
namespace _8_Robot_barmen
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int drinks = Convert.ToInt32(Console.ReadLine());
                int shelves = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(drinks / shelves);

                Console.ReadKey();

            }
            /*
             * 1. DivideByZeroException => "At least 1 shelf"
             * 2. FormatException => "Please insert an integer"
            */
            catch (DivideByZeroException)
            {
                Console.WriteLine("At least 1 shelf");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please insert an integer");
                Console.ReadKey();
            }
        }
    }
}
