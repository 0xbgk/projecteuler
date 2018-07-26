using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Problem4
    {
        public void problem4()
        {
            //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2 - digit numbers is 9009 = 91 × 99.
            //Find the largest palindrome made from the product of two 3 - digit numbers.
            Stopwatch clock = Stopwatch.StartNew();
            int carpim = 0;
            string hesapla;
            int hesapla_uzunluk;
            int buyuk = 1;

            for (int x = 1; x < 1000; x++)
            {
                for (int z = 1; z < 1000; z++)
                {
                    carpim = (x * z);

                    hesapla = carpim.ToString();
                    hesapla_uzunluk = hesapla.Length;

                    if (carpim.ToString().Length % 2 == 0)
                    {
                        string ilk_parca, son_parca;
                        ilk_parca = hesapla.Substring(0, hesapla_uzunluk / 2);
                        son_parca = new string(hesapla.Substring(hesapla_uzunluk / 2, hesapla_uzunluk / 2).ToCharArray().Reverse().ToArray());

                        if (Convert.ToInt32(ilk_parca) == Convert.ToInt32(son_parca))
                        {
                            Console.WriteLine("{0}, {1}", x, z);
                            if (buyuk < carpim)
                            {
                                buyuk = carpim;
                            }
                            Console.WriteLine("{0}", buyuk);
                        }
                    }
                }
            }

            clock.Stop();
            Console.WriteLine("Solution took {0} seconds", (double)clock.ElapsedMilliseconds / 1000);
        }

    }
}
