using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutations
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "maxi";
            printPermutations(str);
            Console.ReadLine();
        }

        static void printPermutations(string str)
        {
            string prefix = "";
            printPermutations(prefix, str);
        }
        static void printPermutations(string prefix, string remainder)
        {
            if (remainder.Length == 1)
            {
                Console.WriteLine(prefix + remainder);
            }
            else
            {
                for (int i=0; i < remainder.Length; i++)
                {
                    string newPrefix = prefix + remainder[i];
                    string newRemainder = remainder.Substring(0,i)+remainder.Substring(i+1);      

                    printPermutations(newPrefix, newRemainder);
                }

            }
         }
    }
}
