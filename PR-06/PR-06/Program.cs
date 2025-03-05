using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PR_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВАРИАНТ № А15/Б12"
                + "\n1. Даны ненулевые числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) лежит в первой координатной четверти»."
                + "\n2. Дано расстояние L в сантиметрах. Найти количество полных метров в нем (1 метр = 100 см)."
                + "\n3. Дан целочисленный массив из N элементов. Найти количество элементов после последнего максимального элемента."
                + "\n4. Вводится строка слов, разделенных подчеркиваниями. Определить количество слов, начинающихся и заканчивающихся на одну букву."
                + "\n5. Вводится строка слов, разделенных подчеркиваниями. Определить количество слов, у которых второй и последний символ одинаковые.");

            Razdel();
            Z01();
            Razdel();
            Z02();
            Razdel();
            Z03();
            Razdel();
            Z04();
            Razdel();
            Z05();
        }

        static void Razdel()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------\n");
        }

        static void Z01()
        {
            Console.WriteLine("Задание 1.\n");
        Start:
            try
            {
                Console.Write("Введите координату x (не равную 0): ");
                double x = Convert.ToDouble(Console.ReadLine());

                if (x == 0)
                {
                    Console.WriteLine("\nОшибка: x не должен быть равен 0.\n");
                    goto Start;
                }

                Console.Write("Введите координату y (не равную 0): ");
                double y = Convert.ToDouble(Console.ReadLine());

                if (y == 0)
                {
                    Console.WriteLine("\nОшибка: y не должен быть равен 0.\n");
                    goto Start;
                }

                if (x > 0 && y > 0)
                {
                    Console.WriteLine("\nВысказывание истинно: точка ({0}, {1}) лежит в первой координатной четверти.", x, y);
                }
                else
                {
                    Console.WriteLine("\nВысказывание ложно: точка ({0}, {1}) не лежит в первой координатной четверти.", x, y);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное число.\n");
                goto Start;
            }
        }

        static void Z02()
        {
            Console.WriteLine("Задание 2.\n");
        Start:
            try
            {
                Console.Write("Введите расстояние L в сантиметрах (целое положительное число): ");
                int L = Convert.ToInt32(Console.ReadLine());

                if (L <= 0)
                {
                    Console.WriteLine("\nОшибка: введите положительное число.\n");
                    goto Start;
                }

                int meters = L / 100;
                Console.WriteLine($"\nВ {L} сантиметрах содержится {meters} полных метров.");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: число слишком большое.\n");
                goto Start;
            }
        }

        static void Z03()
        {
            Console.WriteLine("Задание 3.\n");
        Start:
            try
            {
                Console.Write("Выберите способ заполнения массива (1 - вручную, 2 - автоматически): ");
                int choice = Convert.ToInt32(Console.ReadLine());
                
                if (choice != 1 && choice != 2)
                {
                    Console.WriteLine("\nОшибка: выберите 1 или 2.\n");
                    goto Start;
                }

                Console.Write("Введите размер массива (N > 25): ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n <= 25)
                {
                    Console.WriteLine("\nОшибка: размер массива должен быть больше 25.\n");
                    goto Start;
                }

                int[] array = new int[n];

                if (choice == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Введите элемент {i + 1}: ");
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else
                {
                    Random rand = new Random();
                    Console.WriteLine("\nМассив:");
                    for (int i = 0; i < n; i++)
                    {
                        array[i] = rand.Next(-100, 101);
                        Console.Write($"{array[i]} ");
                    }
                }

                int maxValue = array.Max();
                int lastMaxIndex = Array.LastIndexOf(array, maxValue);
                int elementsAfterMax = n - lastMaxIndex - 1;

                Console.WriteLine($"\n\nКоличество элементов после последнего максимального элемента ({maxValue}): {elementsAfterMax}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное число.\n");
                goto Start;
            }
        }

        static void Z04()
        {
            Console.WriteLine("Задание 4.\n");
        Start:
            Console.WriteLine("Введите строку слов, разделенных подчеркиваниями (минимум 40 символов):");
            string input = Console.ReadLine();

            if (input.Length < 40)
            {
                Console.WriteLine("\nОшибка: длина строки должна быть не менее 40 символов.\n");
                goto Start;
            }

            string[] words = input.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Count(word =>
                word.Length > 0 &&
                char.ToLower(word[0]) == char.ToLower(word[word.Length - 1]));

            Console.WriteLine($"\nКоличество слов, начинающихся и заканчивающихся одной буквой: {count}");
        }

        static void Z05()
        {
            Console.WriteLine("Задание 5.\n");
        Start:
            Console.WriteLine("Введите строку слов, разделенных подчеркиваниями (минимум 40 символов):");
            string input = Console.ReadLine();

            if (input.Length < 40)
            {
                Console.WriteLine("\nОшибка: длина строки должна быть не менее 40 символов.\n");
                goto Start;
            }

            string[] words = input.Split(new[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            int count = words.Count(word =>
                word.Length >= 2 &&
                char.ToLower(word[1]) == char.ToLower(word[word.Length - 1]));

            Console.WriteLine($"\nКоличество слов, у которых второй и последний символ одинаковые: {count}");
        }
    }
}