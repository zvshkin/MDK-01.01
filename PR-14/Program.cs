using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ВАРИАНТ № А15/Б12\n");
                Console.WriteLine("1. Проверить истинность высказывания: \"Квадратное уравнение A·x2 + B·x + C = 0 с данными коэффициентами A(A не равно 0), B, C не имеет вещественных корней\".");
                Console.WriteLine("2. Дано целое положительное пятизначное число N (N > 0). Используя операции деления и определения остатка от деления найти произведение всех его цифр.");
                Console.WriteLine("3. Написать функцию int Max4(A, B, C, D) целого типа, возвращающую одно максимальное значение из 4-х своих аргументов (параметры A, B, C и D - целые числа).");
                Console.WriteLine("4. Написать функцию double Factorial(N) вещественного типа, вычисляющую значение факториала N! = 1*2*…*N (N > 0 — параметр целого типа; вещественное возвращаемое значение используется для того, чтобы избежать целочисленного переполнения при больших значениях N).");
                Console.WriteLine("5. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Найти и вывести все слова, начинающиеся на гласную букву.");
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
                    //case 4:
                    //Zadanie4();
                    //break;
                    //case 5:
                    //Zadanie5();
                    //break;
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
            Console.WriteLine("Задание 1.");
            task1 t1 = new task1();
            double a, b, c;

            while (true)
            {
                Console.Write("Введите А (не равно 0): ");
                if (double.TryParse(Console.ReadLine(), out a) && a != 0)
                    break;
                Console.WriteLine("Ошибка: введите корректое число A, не равное 0");
            }

            while (true)
            {
                Console.Write("Введите B: ");
                if (double.TryParse(Console.ReadLine(), out b))
                    break;
                Console.WriteLine("Ошибка: введите корректое число B");
            }

            while (true)
            {
                Console.Write("Введите C: ");
                if (double.TryParse(Console.ReadLine(), out c))
                    break;
                Console.WriteLine("Ошибка: введите корректое число C");
            }

            try
            {
                bool result = t1.NoReal(a, b, c);
                Console.WriteLine($"Уравнение {(result ? "не имеет" : "имеет")} вещестенных корней.");
            }

            catch (ArgumentException ex)
            {
                Console.WriteLine($"Ошибка: {ex}");
            }
        }

        static void Zadanie2()
        {
            Console.WriteLine("Задание 2.");
            task2 t2 = new task2();
            int n;

            while (true)
            {
                Console.Write("Введите пятизначное число N: ");
                if (!int.TryParse(Console.ReadLine(), out n))
                {
                    Console.WriteLine("Ошибка введите корректное целое число.");
                    continue;
                }
                if (n < 10000 || n > 99999)
                {
                    Console.WriteLine("Ошибка введите 5-значное число.");
                    continue;
                }
                break;
            }
            int result = t2.Delenie(n);
            Console.WriteLine($"Произведение цифр: {result}");
        }
        static void Zadanie3()
        {
            Console.WriteLine("Задание 3.");
            task3 t3 = new task3();
            int a, b, c, d;

            while (true)
            {
                Console.Write("Введите A: ");
                if (int.TryParse(Console.ReadLine(), out a))
                    break;
                Console.WriteLine("Ошибка: введите корректое целое число A");
            }

            while (true)
            {
                Console.Write("Введите B: ");
                if (int.TryParse(Console.ReadLine(), out b))
                    break;
                Console.WriteLine("Ошибка: введите корректое целое число B");
            }

            while (true)
            {
                Console.Write("Введите C: ");
                if (int.TryParse(Console.ReadLine(), out c))
                    break;
                Console.WriteLine("Ошибка: введите корректое целое число C");
            }

            while (true)
            {
                Console.Write("Введите D: ");
                if (int.TryParse(Console.ReadLine(), out d))
                    break;
                Console.WriteLine("Ошибка: введите корректое целое число D");
            }

            int result = t3.Max4(a: a, b: b, c: c, d: d);
            Console.WriteLine($"Максимум: {result}");
            Console.WriteLine($"Максимум (3): {t3.Max4(a: a, b: b, c: c)}");
            Console.WriteLine($"Максимум (2): {t3.Max4(a: a, b: b)}");
        }
    }
}
