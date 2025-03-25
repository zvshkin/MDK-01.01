using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_13
{
    public class task4
    {
        private int start;
        private int end;

        public task4()
        {
            start = 0;
            end = 0;
        }

        public void SetRange(int a, int b)
        {
            if (a <= 0 || b <= 0)
                throw new ArgumentException("Числа должны быть положительными.");
            start = a;
            end = b;
        }

        public int GetStart() => start;
        public int GetEnd() => end;

        public int MulRange()
        {
            if (start == 0 || end == 0)
                throw new InvalidOperationException("Диапазон не задан.");
            if (start > end)
                return 0;
            int result = 1;
            for (int i = start; i <= end; i++)
                result *= i;
            return result;
        }

        public int MulRange(int a)
        {
            if (a <= 0)
                throw new ArgumentException("Начало диапазона должно быть положительным.");
            if (a > end)
                return 0;
            int result = 1;
            for (int i = a; i <= end; i++)
                result *= i;
            return result;
        }

        public int MulRange(int a, int b)
        {
            if (a <= 0 || b <= 0)
                throw new ArgumentException("Числа должны быть положительными.");
            if (a > b)
                return 0;
            int result = 1;
            for (int i = a; i <= b; i++)
                result *= i;
            return result;
        }

        // Статический метод
        public static int MulRangeStatic(int a, int b)
        {
            if (a <= 0 || b <= 0)
                throw new ArgumentException("Числа должны быть положительными.");
            if (a > b)
                return 0;
            int result = 1;
            for (int i = a; i <= b; i++)
                result *= i;
            return result;
        }
    }
}
