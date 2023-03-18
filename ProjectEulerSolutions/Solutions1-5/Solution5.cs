using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions.Solutions
{
    public static class Solution5
    {
        /// <summary>
        /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        /// </summary>
        public static void Solve()
        {
            int uLimit = 20;
            int lLimit = 2;
            int min = lLimit;
            for (int i = lLimit; i <= uLimit; i++)
            {
                if (min % i != 0)
                {
                    min++;
                    i = lLimit;
                }
                else if (i == uLimit && min % i == 0)
                {
                    Console.WriteLine(min);
                    break;
                }
            }
        }
    }
}
