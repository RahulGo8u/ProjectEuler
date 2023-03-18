using Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions.Solutions
{
    static class Solution4
    {
        /// <summary>
        /// Largest palindrome product
        /// A palindromic number reads the same both ways.
        /// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        /// Find the largest palindrome made from the product of two 3-digit numbers.
        /// </summary>
        public static void Solve()
        {
            int max = 0;
            int a = 100;
            int b = 1000;
            for (int i = a; i < b; i++)
            {
                for (int j = a; j < b; j++)
                {
                    int x = i * j;
                    if (MathHelper.IsPalindrome(x) && x > max)
                    {
                        max = x;
                    }
                }
            }
            Console.WriteLine(max);
        }
    }
}
