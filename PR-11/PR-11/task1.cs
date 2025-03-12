using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11
{
    public class task1
    {
        private int number;

        public task1()
        {
            number = 0;
        }

        public void SetNumber(int value)
        {
            if (value < 1000 || value > 9999)
                throw new ArgumentException("Число должно быть четырёхзначным и положительным.");
            number = value;
        }

        public int GetNumber()
        {
            return number;
        }

        public bool CheckSumEquality()
        {
            if (number == 0)
                throw new InvalidOperationException("Число не задано.");
            string numStr = number.ToString();
            int sumFirstTwo = (numStr[0] - '0') + (numStr[1] - '0');
            int sumLastTwo = (numStr[2] - '0') + (numStr[3] - '0');
            return sumFirstTwo == sumLastTwo;
        }
    }
}
