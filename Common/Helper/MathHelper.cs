using System;
using System.Collections.Generic;

namespace Common.Helper
{
    public static class MathHelper
    {
        public static int GetTotal(List<int> lst)
        {
            int sum = 0;
            foreach (int i in lst)
            {
                sum += i;
            }
            return sum;
        }
        public static List<long> GetPrimeFactors(long n)
        {
            List<long> lst = new();
            int i = 2;
            while (n > 1)
            {
                if (n % i == 0)
                {
                    n /= i;
                    lst.Add(i);
                }
                else
                {
                    i++;
                }
            }
            return lst;
        }
        public static bool IsPalindrome(int num)
        {
            string a = num.ToString();
            char[] aCharAry = a.ToCharArray();
            Array.Reverse(aCharAry);
            string b = new(aCharAry);
            return a.Equals(b);
        }
    }
}
