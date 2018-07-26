using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    class Problem14
    {
        //        The following iterative sequence is defined for the set of positive integers:

        //n → n/2 (n is even)
        //n → 3n + 1 (n is odd)

        //Using the rule above and starting with 13, we generate the following sequence:

        //13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
        //It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.

        //Which starting number, under one million, produces the longest chain?

        //NOTE: Once the chain starts the terms are allowed to go above one million.
       
       //837799 525max chain
        public void problem14()
        {
            int count;
            long calc;
            long temp = 0;
            long tempo = 0;

            for (int i = 835000; i <= 837800; i++)
            {
                Console.Write(i + "->");

                calc = i;
                count = 0;                

                while (calc > 1)
                {
                    if (calc % 2 == 0)
                    {
                        calc = calc / 2;
                        count++;
                        Console.Write(calc + "->");
                    }

                    else
                    {
                        calc = (calc * 3) + 1;
                        count++;
                        Console.Write(calc + "->");

                    }
                }
                count++;
                Console.WriteLine("// " + count.ToString() + " chain");
                if (count > temp)
                {
                    tempo = i;
                    temp = count;
                }
            }
            Console.WriteLine(tempo.ToString()+" " +temp.ToString() + "max chain");

        }
    }
}
