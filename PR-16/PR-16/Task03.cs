using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_16
{
    internal class Task03
    {
        public static int ProcessArray(int[] array)
        {
            bool hasNegativeEven = false;
            int sumPositiveOdd = 0;
            int sumDivisibleByThree = 0;

            foreach (int num in array)
            {
                if (num < 0 && num % 2 == 0)
                    hasNegativeEven = true;

                if (num > 0 && num % 2 != 0)
                    sumPositiveOdd += num;

                if (num % 3 == 0)
                    sumDivisibleByThree += num;
            }

            if (hasNegativeEven)
            {
                return sumPositiveOdd;
            }
            else
            {
                return sumDivisibleByThree;
            }
        }
    }
}
