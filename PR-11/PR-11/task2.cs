using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11
{
    public class task2
    {
        private int a;
        private int b;

        public task2()
        {
            a = 0;
            b = 0;
        }

        public void SetNumbers(int first, int second)
        {
            if (first <= 0 || second <= 0)
                throw new ArgumentException("Числа должны быть положительными и ненулевыми.");
            a = first;
            b = second;
        }

        public int GetFirstNumber() => a;
        public int GetSecondNumber() => b;

        public int Sum() => a + b;
        public int Difference() => a - b;
        public int Product() => a * b;
        public double Quotient()
        {
            if (b == 0)
                throw new DivideByZeroException("Деление на ноль невозможно.");
            return (double)a / b;
        }
    }
}
