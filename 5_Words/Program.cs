using System;
/*
 * https://www.sololearn.com/learning/eom-project/1080/1046
 */
namespace _5_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = {
                "home",
                "programming",
                "victory",
                "C#",
                "football",
                "sport",
                "book",
                "learn",
                "dream",
                "fun"
            };

            string letter = Console.ReadLine();

            int count = 0;

            foreach (string s in words)
            {
                if (s.Contains(letter))
                {
                    Console.WriteLine(s);
                    count++;
                }
            }
            if (count < 1) Console.WriteLine("No match");
            Console.ReadKey();

        }
    }
}
