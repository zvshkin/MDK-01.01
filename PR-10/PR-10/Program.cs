using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace PR_10
{
    internal class Program
    {
        private static int number;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ВАРИАНТ № А15/Б12\n");
                Console.WriteLine("1. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Каждое из чисел A, B, C положительное».");
                Console.WriteLine("2. Дано целое положительное трехзначное число. Вывести все числа, полученные при перестановке цифр исходного числа.");
                Console.WriteLine("3. Дан целочисленный массив, состоящий из N элементов (N > 0). Найти и вывести количество элементов, расположенных перед первым минимальным элементом.");
                Console.WriteLine("4. Написать функцию double TriangleP(a) вещественного типа, вычисляющую по стороне a равностороннего треугольника его периметр P = 3·a (параметр a является вещественным). С помощью этой процедуры найти периметры трех равносторонних треугольников с данными сторонами.");
                Console.WriteLine("5. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Найти и вывести длину самого большого слова и вывести это слово на экран.");
                Console.WriteLine("6. Вводится строка, содержащая цифры(от 0 до 9) и строчные латинские буквы. Длина строки может быть разной.Если цифры в строке упорядочены по возрастанию, то вывести число 0; в противном случае вывести номер первого символа строки, нарушающего порядок.");
                Console.WriteLine("7. Вводится строка, содержащая цифры(от 0 до 9) и строчные латинские буквы. Длина строки может быть разной.Если цифры в строке упорядочены по возрастанию, то вывести число 0; в противном случае вывести номер первого символа строки, нарушающего порядок.");
                Console.WriteLine("0. Выход\n");

                Console.WriteLine("\n----------------------------------------------\n");

                Console.Write("Выберите задание (0-7): ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("\nОшибка: введите корректное число.");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        return;
                    case 1:
                        Zadanie1();
                        break;
                    case 2:
                        Zadanie2();
                        break;
                    case 3:
                        Zadanie3();
                        break;
                    case 4:
                        Zadanie4();
                        break;
                    case 5:
                        Zadanie5();
                        break;
                    case 6:
                        Zadanie6();
                        break;
                    case 7:
                        Zadanie7();
                        break;
                    default:
                        Console.WriteLine("\nОшибка: выберите число от 0 до 7.");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }

        // Функция для задания 1
        static bool ProverkaPlus(int A, int B, int C)
        {
            return A > 0 && B > 0 && C > 0;
        }

        static void Zadanie1()
        {
            Console.WriteLine("\nЗадание 1.\n");

            int A = 0;
            int B = 0;
            int C = 0;

            while (true)
            {
                Console.Write("Введите число A: ");
                if (int.TryParse(Console.ReadLine(), out A))
                    break;
                Console.WriteLine("Ошибка: введите корректное целое число.");
            }
            while (true)
            {
                Console.Write("Введите число B: ");
                if (int.TryParse(Console.ReadLine(), out B))
                    break;
                Console.WriteLine("Ошибка: введите корректное целое число.");
            }
            while (true)
            {
                Console.Write("Введите число C: ");
                if (int.TryParse(Console.ReadLine(), out C))
                    break;
                Console.WriteLine("Ошибка: введите корректное целое число.");
            }

            if (ProverkaPlus(A, B, C))
            {
                Console.WriteLine("\nВысказывание: Правдиво");
            }
            else
            {
                Console.WriteLine("\nВысказывание: Ложь");
            }
        }

        // Функция для задания 2
        static List<int> Permutations(int number)
        {
            string numStr = number.ToString();
            List<int> result = new List<int>();

            void Permute(string str, int l, int r)
            {
                if (l == r)
                {
                    result.Add(int.Parse(str));
                }
                else
                {
                    for (int i = l; i <= r; i++)
                    {
                        str = Swap(str, l, i);
                        Permute(str, l + 1, r);
                        str = Swap(str, l, i); // backtrack
                    }
                }
            }

            string Swap(string a, int i, int j)
            {
                char temp;
                char[] charArray = a.ToCharArray();
                temp = charArray[i];
                charArray[i] = charArray[j];
                charArray[j] = temp;
                string s = new string(charArray);
                return s;
            }

            Permute(numStr, 0, numStr.Length - 1);
            return result;

        }
        static void Zadanie2()
        {
            Console.WriteLine("\nЗадание 2.\n");
            while (true)
            {
                Console.Write("Введите трёхзначное число: ");
                if (!int.TryParse(Console.ReadLine(), out int number) || number < 100 || number > 999)
                {
                    Console.WriteLine("\nОшибка: введите трёхзначное положительное число.\n");
                    continue;
                }

                List<int> perms = Permutations(number);
                Console.WriteLine("\nЧисла, полученные перестановкой цифр:");
                foreach (int p in perms)
                {
                    Console.WriteLine(p);
                }
                break;

            }
        }

        // Функция для задания 3
        static int CountElementsBeforeMin(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            int minVal = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal)
                {
                    minVal = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        static void Zadanie3()
        {
            Console.WriteLine("\nЗадание 3.\n");
            while (true)
            {
                Console.Write("Введите размер массива (N > 0): ");
                if (!int.TryParse(Console.ReadLine(), out int n) || n <= 0)
                {
                    Console.WriteLine("\nОшибка: размер массива должен быть больше 0.\n");
                    continue;
                }

                int[] array = new int[n];
                Console.Write("\nВыберите способ заполнения (1 - вручную, 2 - автоматически): ");
                if (!int.TryParse(Console.ReadLine(), out int choice) || (choice != 1 && choice != 2))
                {
                    Console.WriteLine("\nОшибка: выберите 1 или 2.\n");
                    continue;
                }

                if (choice == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        while (true)
                        {
                            Console.Write($"Введите элемент {i + 1}: ");
                            if (int.TryParse(Console.ReadLine(), out array[i]))
                                break;
                            Console.WriteLine("Ошибка: введите корректное число.");
                        }
                    }
                }
                else
                {
                    Random rand = new Random();
                    for (int i = 0; i < n; i++)
                        array[i] = rand.Next(-100, 101); // Пример диапазона

                    Console.WriteLine("\nСгенерированный массив:");
                    Console.WriteLine(string.Join(" ", array));
                }

                int count = CountElementsBeforeMin(array);
                Console.WriteLine($"\nКоличество элементов перед первым минимальным: {count}");
                break;
            }
        }

        // Функция для задания 4
        static double TriangleP(double a)
        {
            return 3 * a;
        }

        static void Zadanie4()
        {
            Console.WriteLine("\nЗадание 4.\n");
            double[] sides = new double[3];
            string[] labels = { "первого", "второго", "третьего" };

            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Write($"Введите сторону {labels[i]} треугольника: ");
                    if (double.TryParse(Console.ReadLine(), out sides[i]) && sides[i] > 0)
                        break;
                    Console.WriteLine("Ошибка: введите корректное положительное число.");
                }
            }

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Периметр {labels[i]} треугольника: {TriangleP(sides[i])}");
            }
        }

        // Функция для задания 5
        static (int, string) FindLongestWord(string input)
        {
            string[] words = input.Split('_');
            string longestWord = "";
            int maxLength = 0;

            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {
                    maxLength = word.Length;
                    longestWord = word;
                }
            }

            return (maxLength, longestWord);
        }

        static void Zadanie5()
        {
            Console.WriteLine("\nЗадание 5.\n");
            Console.WriteLine("Введите строку, состоящую из слов, разделенных подчеркиваниями:");
            string input = Console.ReadLine();

            var (length, word) = FindLongestWord(input);
            Console.WriteLine($"\nДлина самого большого слова: {length}");
            Console.WriteLine($"Самое большое слово: {word}");
        }

        // Функция для задания 6
        static int CheckOrder(string input)
        {
            int prevDigit = -1;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    int currentDigit = int.Parse(input[i].ToString());
                    if (currentDigit <= prevDigit)
                    {
                        return i + 1; // Номер символа (начиная с 1)
                    }
                    prevDigit = currentDigit;
                }
            }
            return 0;
        }

        static void Zadanie6()
        {
            Console.WriteLine("\nЗадание 6.\n");
            Console.WriteLine("Введите строку, содержащую цифры и строчные латинские буквы:");
            string input = Console.ReadLine();

            int result = CheckOrder(input);
            Console.WriteLine(result);
        }
    }
}