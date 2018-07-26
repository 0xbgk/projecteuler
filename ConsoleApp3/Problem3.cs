using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Problem3
    {
        public void problem3()
        {

            //The prime factors of 13195 are 5, 7, 13 and 29.
            //What is the largest prime factor of the number 600851475143 ?
            Stopwatch clock = Stopwatch.StartNew();
            bool asalmi(long x)
            {
                bool asal = false;
                int bolensayisi = 0;
                for (int i = 1; i <= (x / 2) + 10; i++)
                {
                    if (x % i == 0)
                    {
                        bolensayisi++;
                        if (bolensayisi > 2)
                        {
                            asal = false;

                        }
                        else
                        {
                            asal = true;
                        }
                    }
                }
                return asal;
            }

            for (long i = 2; i < 300851475143; i++)
            {
                if (asalmi(i))
                {
                    Console.Write(".", i);

                    if (600851475143 % i == 0)
                    {
                        Console.WriteLine("{0} asallar", i);
                    }
                }
            }

            clock.Stop();
            Console.WriteLine("Solution took {0} seconds", (double)clock.ElapsedMilliseconds / 1000);

        }

    }
}
