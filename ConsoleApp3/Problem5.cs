using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Problem5
    {
        void problem5()
        {
            int a = 1;
            int boldu = 0;
            bool kontrol = true;

            do
            {
                if (a % 1 == 0 &&
                    a % 2 == 0 &&
                    a % 3 == 0 &&
                    a % 4 == 0 &&
                    a % 5 == 0 &&
                    a % 6 == 0 &&
                    a % 7 == 0 &&
                    a % 8 == 0 &&
                    a % 9 == 0 &&
                    a % 10 == 0 &&
                    a % 11 == 0 &&
                    a % 12 == 0 &&
                    a % 13 == 0 &&
                    a % 14 == 0 &&
                    a % 15 == 0 &&
                    a % 16 == 0 &&
                    a % 17 == 0 &&
                    a % 18 == 0 &&
                    a % 19 == 0 &&
                    a % 20 == 0)
                {
                    kontrol = false;
                }
                else
                {
                    a++;
                }
            } while (kontrol);

            Console.WriteLine("{0}", a);

        }

    }
}
