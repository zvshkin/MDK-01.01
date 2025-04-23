using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_16
{
    internal class Task04
    {
        public static bool IsPalindrome(int K)
        {
            if (K <= 0 || K >= 10000)
                throw new ArgumentException("Число должно быть четырехзначным.");

            int firstDigit = K / 1000;
            int lastDigit = K % 10;
            int secondDigit = (K / 100) % 10;
            int thirdDigit = (K / 10) % 10;

            return firstDigit == lastDigit && secondDigit == thirdDigit;
        }
    }
}
