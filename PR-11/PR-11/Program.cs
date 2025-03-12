using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ВАРИАНТ № А15/Б12\n");
                Console.WriteLine("1. Проверить истинность высказывания: \"Сумма двух первых цифр данного четырехзначного целого положительного числа равна сумме двух его последних цифр\".");
                Console.WriteLine("2. Ввести два ненулевых положительных целых числа. Найти и вывести на экран их сумму, разность, произведение и частное.");
                Console.WriteLine("3. Дан целочисленный массив, состоящий из N элементов (N > 0). Проверить, чередуются ли в нем положительные и отрицательные числа.");
                Console.WriteLine("4. Написать функцию int TimeToDay(H, M, S) целого типа, которая возвращает общее количество прошедших дней.");
                Console.WriteLine("0. Выход\n");
                Razdel();

                Console.Write("\nВыберите задание (0-4): ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Ошибка: введите корректное число.");
                    WaitForKey();
                    continue;
                }

                try
                {
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
                        default:
                            Console.WriteLine("Ошибка: выберите число от 0 до 4.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
                WaitForKey();
            }
        }

        static void Razdel()
        {
            Console.WriteLine(new string('─', 70));
        }

        static void WaitForKey()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }

        static void Zadanie1()
        {
            Console.WriteLine("Задание 1:");
            task1 t1 = new task1();
            while (true)
            {
                Console.Write("Введите четырёхзначное число: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    try
                    {
                        t1.SetNumber(num);
                        Console.WriteLine($"Результат: {t1.CheckSumEquality()}");
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное целое число.");
                }
            }
        }

        static void Zadanie2()
        {
            Console.WriteLine("Задание 2:");
            task2 t2 = new task2();
            int a, b;

            while (true)
            {
                Console.Write("Введите первое число: ");
                if (int.TryParse(Console.ReadLine(), out a))
                    break;
                Console.WriteLine("Ошибка: введите корректное целое число.");
            }

            while (true)
            {
                Console.Write("Введите второе число: ");
                if (int.TryParse(Console.ReadLine(), out b))
                {
                    try
                    {
                        t2.SetNumbers(a, b);
                        Console.WriteLine($"Сумма: {t2.Sum()}");
                        Console.WriteLine($"Разность: {t2.Difference()}");
                        Console.WriteLine($"Произведение: {t2.Product()}");
                        Console.WriteLine($"Частное: {t2.Quotient()}");
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное целое число.");
                }
            }
        }

        static void Zadanie3()
        {
            Console.WriteLine("Задание 3:");
            task3 t3 = new task3();
            int n;

            while (true)
            {
                Console.Write("Введите размер массива: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                    break;
                Console.WriteLine("Ошибка: введите корректное положительное число.");
            }

            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Элемент {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out arr[i]))
                        break;
                    Console.WriteLine("Ошибка: введите корректное целое число.");
                }
            }

            try
            {
                t3.SetArray(arr);
                int result = t3.CheckAlternation();
                Console.WriteLine($"Результат: {result}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void Zadanie4()
        {
            Console.WriteLine("Задание 4:");
            task4 t4 = new task4();
            int h, m, s;

            while (true)
            {
                Console.Write("Введите часы: ");
                if (int.TryParse(Console.ReadLine(), out h))
                    break;
                Console.WriteLine("Ошибка: введите корректное целое число.");
            }

            while (true)
            {
                Console.Write("Введите минуты: ");
                if (int.TryParse(Console.ReadLine(), out m))
                {
                    try
                    {
                        t4.SetTime(h, m, 0);
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное целое число.");
                }
            }

            while (true)
            {
                Console.Write("Введите секунды: ");
                if (int.TryParse(Console.ReadLine(), out s))
                {
                    try
                    {
                        t4.SetTime(h, m, s);
                        Console.WriteLine($"Количество дней: {t4.TimeToDay()}");
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное целое число.");
                }
            }
        }
    }
}