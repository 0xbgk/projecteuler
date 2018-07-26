using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecteuler
{
    //Using names.txt(right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
    //For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.
    //What is the total of all the name scores in the file?
    class Problem22
    {
        string filename;
        string temp;
        string tempnocomma;
        string temporaryname;
        string line;
        int value;
        long sum;
        List<string> names = new List<string>();
        List<int> values = new List<int>();
        void getfile()
        {
            filename = "p022_names.txt";
            StreamReader sr = new StreamReader(filename);

            while ((line = sr.ReadLine()) != null)
            {
                temp += line;                
            }
        }
        void clearcommas()
        {
            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] == ',')
                {
                    tempnocomma += ' ';
                }
                else if (temp[i] == '"')
                {
                    tempnocomma += ' ';
                }
                else
                {
                    tempnocomma += temp[i];
                }             
            }
        }

        void seperatenames()
        {
            temporaryname = "";
            for (int i = 1; i < tempnocomma.Length; i++)
            {
                if (tempnocomma[i] == ' ')
                {
                    names.Add(temporaryname.Trim());
                    temporaryname = "";
                }
                else
                {
                    temporaryname += tempnocomma[i];
                }
            }            
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == "")
                {
                    names.RemoveAt(i);
                }
                else if (names[i] == " ")
                {
                    names.RemoveAt(i);
                }                
            }
            for (int i = 0; i < names.Count; i++)
            {
                if (names[i] == "")
                {
                    names.RemoveAt(i);
                }
                else if (names[i] == " ")
                {
                    names.RemoveAt(i);
                }
            }

        }        
        void valuenames()
        {
            string temp;            

            names.Sort();

            for (int i = 0; i < names.Count; i++)
            {
                value = 0;
                temp = names[i];
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] == 'A')
                    {
                        value += 1;
                    }
                    else if (temp[j] == 'B')
                    {
                        value += 2;
                    }
                    else if (temp[j] == 'C')
                    {
                        value += 3;
                    }
                    else if (temp[j] == 'D')
                    {
                        value += 4;
                    }
                    else if (temp[j] == 'E')
                    {
                        value += 5;
                    }
                    else if (temp[j] == 'F')
                    {
                        value += 6;
                    }
                    else if (temp[j] == 'G')
                    {
                        value += 7;
                    }
                    else if (temp[j] == 'H')
                    {
                        value += 8;
                    }
                    else if (temp[j] == 'I')
                    {
                        value += 9;
                    }
                    else if (temp[j] == 'J')
                    {
                        value += 10;
                    }
                    else if (temp[j] == 'K')
                    {
                        value += 11;
                    }
                    else if (temp[j] == 'L')
                    {
                        value += 12;
                    }
                    else if (temp[j] == 'M')
                    {
                        value += 13;
                    }
                    else if (temp[j] == 'N')
                    {
                        value += 14;
                    }
                    else if (temp[j] == 'O')
                    {
                        value += 15;
                    }
                    else if (temp[j] == 'P')
                    {
                        value += 16;
                    }
                    else if (temp[j] == 'Q')
                    {
                        value += 17;
                    }
                    else if (temp[j] == 'R')
                    {
                        value += 18;
                    }
                    else if (temp[j] == 'S')
                    {
                        value += 19;
                    }
                    else if (temp[j] == 'T')
                    {
                        value += 20;
                    }
                    else if (temp[j] == 'U')
                    {
                        value += 21;
                    }
                    else if (temp[j] == 'V')
                    {
                        value += 22;
                    }
                    else if (temp[j] == 'W')
                    {
                        value += 23;
                    }
                    else if (temp[j] == 'X')
                    {
                        value += 24;
                    }
                    else if (temp[j] == 'Y')
                    {
                        value += 25;
                    }
                    else if (temp[j] == 'Z')
                    {
                        value += 26;
                    }
                }
                values.Add(value);
            }

         
        }

        public void problem22()
        {
            Stopwatch clock = Stopwatch.StartNew();

            getfile();
            clearcommas();

            seperatenames();
            names.Sort();

            valuenames();

            for (int i = 0; i < values.Count; i++)
            {
                sum += (i + 1) * values[i];
            }
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine((i+1)+"." + names[i] +","+ values[i]);
            }
            Console.WriteLine("SUM = "+sum);
            

            clock.Stop();
            Console.WriteLine("Solution took {0} seconds", (double)clock.ElapsedMilliseconds / 1000);
        }
    }
}
