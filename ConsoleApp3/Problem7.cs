using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Problem7
    {
        void problem7()
        {
            //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            //What is the 10 001st prime number ?


            int asalmi = 1;
            int bolen_sayisi = 0;
            int maxasal = 0;
            int count = 1;
            do
            {
                bolen_sayisi = 0;
                asalmi++;
                for (int i = 1; i <= asalmi; i++)
                {
                    if (asalmi % i == 0)
                    {
                        bolen_sayisi++;
                    }
                }
                if (bolen_sayisi > 2)
                {
                }
                else
                {
                    Console.WriteLine("{0}.asal {1}", count, asalmi);
                    maxasal = asalmi;
                    count++;
                }
                if (count == 10002)
                {
                    break;
                }
            } while (true);

        }

    }
}
