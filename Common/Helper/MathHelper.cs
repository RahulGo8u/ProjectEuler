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
    }
}
