using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Problem6
    {
        public void problem6()
        {
            //The sum of the squares of the first ten natural numbers is,
            //1^2 + 2^2 + ... + 10^2 = 385
            //The square of the sum of the first ten natural numbers is,
            //(1 + 2 + ... + 10)^2 = 55^2 = 3025
            //Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
            //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
            Stopwatch clock = Stopwatch.StartNew();

            double total = 0;
            double total_kare = 0;
            double tekli_kare = 0;
            total = (100 * 101) / 2;
            total_kare = Math.Pow(total, 2);
            for (int i = 1; i <= 100; i++)
            {
                tekli_kare += Math.Pow(i, 2);
            }

            Console.WriteLine("{0}", total_kare);

            Console.WriteLine("----------");

            Console.WriteLine("{0}", tekli_kare);

            Console.WriteLine("----------");

            Console.WriteLine("{0}", total_kare - tekli_kare);

            clock.Stop();
            Console.WriteLine("Solution took {0} seconds", (double)clock.ElapsedMilliseconds / 1000);
        }

    }
}
