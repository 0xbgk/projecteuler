using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Problem10
    {
        public void problem10()
        {
            //The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
            //Find the sum of all the primes below two million.

            Stopwatch clock = Stopwatch.StartNew();
            long toplam = 0;
            int sayi = 2;

            bool asalmi(int x)
            {
                int bolen_sayisi = 0;
                bool kontrol = false;

                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        bolen_sayisi++;
                    }
                    if (bolen_sayisi > 2)
                    {
                        break;
                    }
                }
                if (bolen_sayisi == 2)
                {
                    kontrol = true;
                }
                return kontrol;
            }

            while (sayi < 2000000)
            {
                if (asalmi(sayi))
                {
                    toplam += sayi;
                    sayi++;
                    Console.WriteLine("{0}", toplam);
                }
                else
                {
                    sayi++;
                }

            }

            clock.Stop();
            Console.WriteLine("Solution took {0} seconds", (double)clock.ElapsedMilliseconds / 1000);

        }

    }
}
