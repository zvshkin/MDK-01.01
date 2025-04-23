using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_16
{
    internal class Task05
    {
        public static (int count, int sum) CountAndSumNumbers(string input)
        {
            int count = 0;
            int sum = 0;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    count++;
                    sum += c - '0';
                }
            }

            return (count, sum);
        }
    }
}
