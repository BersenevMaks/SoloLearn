using System;
/*
 * https://www.sololearn.com/learning/eom-project/1080/1023
 */
namespace Level_Points
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Points(levels));
            Console.ReadKey();
        }


        static int Points(int levels)
        {
            int sum = 0;
            while (levels > 0)
                sum += levels--;
            return sum;

        }
    }
}
