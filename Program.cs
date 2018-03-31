using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace A_Fuzzy_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            FuzzySolution1();
            FuzzySolution2();
            FuzzySolution3();

            Console.WriteLine("\t" + "***PRESS ANY KEY TO END PROGRAM***");
            Console.ReadKey();
        }

        private static void FuzzySolution3()
        {
            Console.WriteLine("\t"+ "*** SOLUTION 3 - START ***");
            Enumerable.Range(1, 100).Select(x =>
                (x % 15 == 0)
                    ? "FizzBuzz"
                    : (x % 5 == 0)
                        ? "Buzz"
                        : (x % 3 == 0)
                            ? "Fizz"
                            : x.ToString()).ToList().ForEach(Console.WriteLine);
        }

        private static void FuzzySolution2()
        {
            string[] template = {"{0}", "Fizz", "Buzz", "FizzBuzz" };
            Console.WriteLine("\t" + "*** SOLUTION 2 - START ***");
            for (int i = 1; i < 100; i++)
            {
                Console.WriteLine(template[Convert.ToInt32(i % 3 == 0) + Convert.ToInt32(i % 5 == 0)*2],i);
            }
        }

        private static void FuzzySolution1()
        {
            Console.WriteLine("\t" + "*** SOLUTION 1 - START ***");
            for (int i = 1; i < 100; i++)
            {
                bool divideby3 = (i % 3) == 0;
                bool divideby5 = (i % 5) == 0;

                if (divideby3 && divideby5)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (divideby3)
                {
                    Console.WriteLine("Fizz");
                }
                else if (divideby5)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }   
    }
}
