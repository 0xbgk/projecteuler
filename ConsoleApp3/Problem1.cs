using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Problem1
    {
         public void problem1()
        {
            // If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
            // Find the sum of all the multiples of 3 or 5 below 1000.
            int toplam = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.WriteLine("{0}", i);
                    toplam += i;
                }
            }
            Console.WriteLine("{0}", toplam);
        }

    }
}
