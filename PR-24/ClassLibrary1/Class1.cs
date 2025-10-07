using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TaskSolutions
    {
        /// <summary>
        /// Находим кол-во положительных чисел в наборе
        /// </summary>
        /// <param name="numbers">набор чисел</param>
        /// <returns>кол-во положительных чисел</returns>
        public static int CountPositiveNumbers(int[] numbers)
        {
            return numbers.Count(num => num > 0);
        }

        /// <summary>
        /// сложение с нечетными числами максимальное четное число из массива
        /// </summary>
        /// <param name="array">массив целых чисел</param>
        public static void AddMaxEvenToOdds(int[] array)
        {
            int maxEven = array.Where(x => x % 2 == 0).Max();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    array[i] += maxEven;
                }
            }
        }

        /// <summary>
        /// нахождение количества элементов, расположенных перед первым минимальным элементом
        /// </summary>
        /// <param name="array">массив целых чисел</param>
        /// <returns>количество элементов перед первым минимальным элементом</returns>
        public static int CountBeforeMin(int[] array)
        {
            int minValue = array.Min();
            int minIndex = Array.IndexOf(array, minValue);
            return minIndex;
        }

        /// <summary>
        /// получаем N-й цифры числа
        /// </summary>
        /// <param name="K">1 положительное число</param>
        /// <param name="N">номер цифры</param>
        /// <returns>возвращает N-ю цифру числа, если таковая существует, иначе -1.</returns>
        public static int DigitN(int K, int N)
        {
            string numberStr = K.ToString();
            if (N > numberStr.Length)
                return -1;

            return int.Parse(numberStr[numberStr.Length - N].ToString());
        }
    }
}
