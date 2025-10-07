using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace PR_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // задание 1: ввод набора чисел и подсчет положительных
            Console.WriteLine("Задача 1: Найти количество положительных чисел в наборе");
            int[] numbers = GetIntArrayFromUser();
            Console.WriteLine("Количество положительных чисел: " + TaskSolutions.CountPositiveNumbers(numbers));

            // задание 2: ввод массива чисел и операция сложения с максимальным четным
            Console.WriteLine("\nЗадача 2: Сложить с нечетными числами максимальное четное число из массива");
            int[] array2 = GetIntArrayFromUser();
            TaskSolutions.AddMaxEvenToOdds(array2);
            Console.WriteLine("Новый массив: " + string.Join(" ", array2));

            // задание 3: ввод массива чисел и подсчет элементов до первого минимального
            Console.WriteLine("\nЗадача 3: Количество элементов перед первым минимальным элементом");
            int[] array3 = GetIntArrayFromUser();
            Console.WriteLine("Количество элементов перед первым минимальным: " + TaskSolutions.CountBeforeMin(array3));

            // задание 4: ввод числа и получение N-й цифры
            Console.WriteLine("\nЗадача 4: Получить N-ю цифру числа");
            int K = GetIntFromUser("Введите число K: ");
            int N = GetIntFromUser("Введите номер цифры N: ");
            Console.WriteLine("N-я цифра числа: " + TaskSolutions.DigitN(K, N));
        }

        // метод для ввода целого числа с проверкой
        static int GetIntFromUser(string prompt)
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Ошибка: введено некорректное число. Попробуйте снова.");
                }
            }
        }

        // метод для ввода массива целых чисел с проверкой
        static int[] GetIntArrayFromUser()
        {
            while (true)
            {
                Console.Write("Введите числа через пробел: ");
                string input = Console.ReadLine();
                string[] parts = input.Split(' ');
                try
                {
                    int[] array = Array.ConvertAll(parts, int.Parse);
                    return array;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введены некорректные данные. Попробуйте снова.");
                }
            }
        }
    }
}
