﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Problem12
    {

        //The sequence of triangle numbers is generated by adding the natural numbers.So the 7th triangle number would be 1 + 2 + 3 + 4 + 5 + 6 + 7 = 28. The first ten terms would be:

        //1, 3, 6, 10, 15, 21, 28, 36, 45, 55, ...

        //Let us list the factors of the first seven triangle numbers:

        // 1: 1
        // 3: 1,3
        // 6: 1,2,3,6
        //10: 1,2,5,10
        //15: 1,3,5,15
        //21: 1,3,7,21
        //28: 1,2,4,7,14,28
        //We can see that 28 is the first triangle number to have over five divisors.

        //What is the value of the first triangle number to have over five hundred divisors?
        public bool asal_kontrol(long x)
        {
            bool asal = false;
            int kontrol = 0;
            for (int i = 1; i <= x; i++)
            {
                if (x % i == 0)
                {
                    kontrol++;
                }
                if (kontrol > 2)
                {
                    asal = false;
                    break;
                }
                else if (kontrol == 2)
                {
                    asal = true;
                }
            }
            return asal;
        }
        public long triangle_number(long x)
        {
            long y = 0;
            y = (x * (x + 1)) / 2;
            return y;
        }

        public int bolenler(long x)
        {
            int start = 1;
            for (int i = 1; i <= (x/2); i++)
            {
                if (x % i == 0)
                {
                    start++;
                }
            }
            return start;
        }

        public void problem12()
        {
            Stopwatch clock = Stopwatch.StartNew();
            int x = 1;

            while (true)
            {
                Console.WriteLine(triangle_number(x) + " " + bolenler(triangle_number(x)));
                if (bolenler(triangle_number(x)) >= 500)
                {
                    break;
                }
                x++;
            }



            clock.Stop();
            Console.WriteLine("Solution took {0} seconds", (double)clock.ElapsedMilliseconds / 1000);
            //for (int i = 1; i < 102; i++)
            //{
            //    for (int x = 1; x <= triangle_number(i); x++)
            //    {
            //        if (asal_kontrol(x))
            //        {
            //            if (triangle_number(i) % x == 0)
            //            {
            //                Console.WriteLine(" " + triangle_number(i) + " " + x +"bolenler" + bolenler(triangle_number(i)));
            //            }
            //        }

            //    }
            //    Console.WriteLine();
            //}

        }

        //public void problem12()
        //{

        //    long triangle_number = 0;
        //    int bolen = 0;
        //    string bolenler;
        //    bolenler = "";
        //    bool devam = true;
        //    while (devam)
        //    {
        //        for (int i = 1; ;)
        //        {
        //            triangle_number += i;
        //            for (int j = 1; j <= (triangle_number); j++)
        //            {
        //                if (triangle_number % j == 0)
        //                {
        //                    bolen++;
        //                    bolenler += j + ",";
        //                }
        //            }

        //            Console.WriteLine(i + ". " + triangle_number + " " + bolen + "Bolen " + bolenler);
        //            Console.WriteLine();
        //            if (bolen == 500)
        //            {
        //                devam = false;
        //                break;
        //            }
        //            bolen = 0;
        //            bolenler = "";
        //            i++;
        //        }

        //    }

        //}

    }
}
