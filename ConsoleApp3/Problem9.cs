using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Problem9
    {
        public void problem9()
        {
            Stopwatch clock = Stopwatch.StartNew();
            double a, b, c;
            a = 1;
            b = 1;
            c = 1;
            double sonuc = 0;
            //200,375,425

            for (a = 1; a < 1000; a++)
            {
                for (b = 1; b < 1000; b++)
                {
                    for (c = 1; c < 1000; c++)
                    {

                        if ((Math.Pow(c, 2) == Math.Pow(a, 2) + Math.Pow(b, 2)) && (a + b + c == 1000))
                        {

                            Console.WriteLine("{0} , {1}, {2}", a, b, c);
                        }
                    }
                }
            }


            sonuc = a * b * c;
            clock.Stop();
            Console.WriteLine("Solution took {0} seconds", (double)clock.ElapsedMilliseconds / 1000);
        }

    }
}
