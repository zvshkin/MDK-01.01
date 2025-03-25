using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ВАРИАНТ № А15/Б12\n");
                Console.WriteLine("1. Найти количество полных тонн в массе M.");
                Console.WriteLine("2. Сложить с нечетными числами максимальное четное в массиве.");
                Console.WriteLine("3. Найти периметр равнобедренного треугольника по основанию и высоте.");
                Console.WriteLine("4. Найти произведение чисел от A до B.");
                Console.WriteLine("5. Подсчитать слова с одной буквой 'h' в строке.");
                Console.WriteLine("0. Выход\n");
                Razdel();

                Console.Write("Выберите задание (0-5): ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Ошибка: введите корректное число.");
                    WaitForKey();
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
                    default:
                        Console.WriteLine("Ошибка: выберите число от 0 до 5.");
                        break;
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
                Console.Write("Введите массу (кг): ");
                if (int.TryParse(Console.ReadLine(), out int m))
                {
                    try
                    {
                        t1.SetMass(m);
                        Console.WriteLine($"Тонн (динамический): {t1.GetTons()}");
                        Console.WriteLine($"Тонн (статический): {task1.GetTonsStatic(m)}");
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
                t2.SetArray(arr);
                Console.WriteLine("Новый массив (динамический): " + string.Join(" ", t2.AddMaxEven()));
                Console.WriteLine("Новый массив (статический): " + string.Join(" ", task2.AddMaxEvenStatic(arr)));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static void Zadanie3()
        {
            Console.WriteLine("Задание 3:");
            task3 t3 = new task3();
            double a, h;

            while (true)
            {
                Console.Write("Введите основание: ");
                if (double.TryParse(Console.ReadLine(), out a))
                    break;
                Console.WriteLine("Ошибка: введите корректное число.");
            }

            while (true)
            {
                Console.Write("Введите высоту: ");
                if (double.TryParse(Console.ReadLine(), out h))
                {
                    try
                    {
                        t3.SetDimensions(a, h);
                        Console.WriteLine($"Периметр (без аргументов): {t3.TriangleP()}");
                        Console.WriteLine($"Периметр (с основанием): {t3.TriangleP(a: a)}");
                        Console.WriteLine($"Периметр (полный): {t3.TriangleP(a: a, h: h)}");
                        Console.WriteLine($"Периметр (статический): {task3.TrianglePStatic(a: a, h: h)}");
                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Ошибка: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное число.");
                }
            }
        }

        static void Zadanie4()
        {
            Console.WriteLine("Задание 4:");
            task4 t4 = new task4();
            int a, b;

            while (true)
            {
                Console.Write("Введите A: ");
                if (int.TryParse(Console.ReadLine(), out a))
                    break;
                Console.WriteLine("Ошибка: введите корректное целое число.");
            }

            while (true)
            {
                Console.Write("Введите B: ");
                if (int.TryParse(Console.ReadLine(), out b))
                {
                    try
                    {
                        t4.SetRange(a, b);
                        Console.WriteLine($"Произведение (без аргументов): {t4.MulRange()}");
                        Console.WriteLine($"Произведение (с A): {t4.MulRange(a: a)}");
                        Console.WriteLine($"Произведение (полное): {t4.MulRange(a: a, b: b)}");
                        Console.WriteLine($"Произведение (статический): {task4.MulRangeStatic(a: a, b: b)}");
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

        static void Zadanie5()
        {
            Console.WriteLine("Задание 5:");
            task5 t5 = new task5();
            Console.Write("Введите строку (слова через '_'): ");
            string input = Console.ReadLine();

            try
            {
                t5.SetInput(input);
                Console.WriteLine($"Количество слов (динамический): {t5.CountWordsWithOneH()}");
                Console.WriteLine($"Количество слов (статический): {task5.CountWordsWithOneHStatic(input)}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
