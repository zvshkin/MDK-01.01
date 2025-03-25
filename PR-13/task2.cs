using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_13
{
    public class task2
    {
        private int[] array;

        public task2()
        {
            array = new int[0];
        }

        public void SetArray(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Массив не может быть пустым или null.");
            array = arr;
        }

        public int[] GetArray() => array;

        public int[] AddMaxEven()
        {
            if (array.Length == 0)
                throw new InvalidOperationException("Массив не задан.");
            int maxEven = array.Where(x => x % 2 == 0).DefaultIfEmpty(int.MinValue).Max();
            if (maxEven == int.MinValue)
                return array; // Нет чётных чисел
            return array.Select(x => x % 2 != 0 ? x + maxEven : x).ToArray();
        }

        public static int[] AddMaxEvenStatic(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Массив не может быть пустым или null.");
            int maxEven = arr.Where(x => x % 2 == 0).DefaultIfEmpty(int.MinValue).Max();
            if (maxEven == int.MinValue)
                return arr;
            return arr.Select(x => x % 2 != 0 ? x + maxEven : x).ToArray();
        }
    }
}
