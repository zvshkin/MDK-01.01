using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11
{
    public class task3
    {
        private int[] array;

        public task3()
        {
            array = new int[0];
        }

        public void SetArray(int[] values)
        {
            if (values == null || values.Length == 0)
                throw new ArgumentException("Массив не может быть пустым или null.");
            array = values;
        }

        public int[] GetArray()
        {
            return array;
        }

        public int CheckAlternation()
        {
            if (array.Length < 2)
                return 0;
            bool expectPositive = array[0] > 0;
            for (int i = 1; i < array.Length; i++)
            {
                bool isPositive = array[i] > 0;
                if (isPositive == expectPositive)
                    return i;
                expectPositive = !expectPositive;
            }
            return 0;
        }
    }
}
