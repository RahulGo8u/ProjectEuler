using Common.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions.Solutions
{
    public static class Solution3
    {
        /// <summary>
        /// Largest prime factor
        /// The prime factors of 13195 are 5, 7, 13 and 29.
        /// What is the largest prime factor of the number 600851475143 ?
        /// </summary>
        public static void Solve()
        {
            long num = 600851475143;
            List<long> lstPrimeFactors = MathHelper.GetPrimeFactors(num);
            Console.WriteLine(lstPrimeFactors.Max());
        }
    }
}
