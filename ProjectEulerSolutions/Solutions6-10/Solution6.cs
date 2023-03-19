using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEulerSolutions.Solutions
{
    static class Solution6
    {
        /// <summary>
        /// The sum of the squares of the first ten natural numbers is,
        /// The square of the sum of the first ten natural numbers is,
        /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 
        /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum
        /// </summary>
        public static void Solve()
        {
            var uLimit = 100;
            double sumOfSquares = 0;
            double squaresOfSum = 0;
            for (int i = 1; i <= uLimit; i++)
            {
                sumOfSquares += Math.Pow(i, 2);
                squaresOfSum += i;
            }
            Console.WriteLine(Math.Pow(squaresOfSum, 2) - sumOfSquares);
        }
    }
}
