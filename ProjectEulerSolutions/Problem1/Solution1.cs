using Common.Helper;
using System;
using System.Collections.Generic;

namespace ProjectEulerSolutions.Problem
{
    static class Solution1
    {
        /// <summary>
        /// Multiples of 3 or 5
        /// If we list all the natural numbers below 10 that are multiples of 3 or 5, 
        /// we get 3, 5, 6 and 9. The sum of these multiples is 23.
        /// Find the sum of all the multiples of 3 or 5 below 1000.
        /// </summary>
        public static void Solve()
        {
            int uLimit = 1000;
            List<int> lstMultiples = new();
            for(int i = 2; i < uLimit; i++)
            {
                if (i % 5 == 0 || i % 3 == 0) lstMultiples.Add(i);
            }
            Console.WriteLine(MathHelper.GetTotal(lstMultiples));
        }
    }
}
