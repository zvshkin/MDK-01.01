using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PR_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВАРИАНТ № А15/Б12"
                + "\n1. Проверить истинность высказывания: \"Сумма двух первых цифр данного целого положительного четырехзначного числа равна сумме двух его последних цифр\"."
                + "\n2. Дано целое положительное трехзначное число. В нем зачеркнули первую справа цифру и приписали ее слева. Вывести полученное новое число."
                + "\n3. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное»."
                + "\n4. Даны два целых положительных числа A и B (число A меньше числа B). Найти произведение всех четных чисел расположенных между этими числами A и B."
                + "\n5. Мастям игральных карт присвоены порядковые номера: 1 - пики, 2 - трефы, 3 - бубны, 4 - червы. Достоинству карт, старших десятки, присвоены номера: 11 - валет, 12 - дама, 13 - король, 14 - туз. Даны два целых числа: N - достоинство (6 <= N <= 14) и M - масть карты (1 <= M <= 4). Вывести название соответствующей карты вида «шестерка бубен», «дама червей», «туз треф» и т. п.");

            Otdel();
            Z01();
            Otdel();
            Z02();
            Otdel();
            Z03();
            Otdel();
            Z04();
            Otdel();
            Z05();
        }

        static void Otdel()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------\n");
        }

        static void Z01()
        {
            Console.WriteLine("Задание 1.\n");
        Start:
            try
            {
                Console.WriteLine("Введите целое положительное четырехзначное число:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 1000 || num > 9999)
                {
                    Console.WriteLine("\nОшибка: введите положительное четырехзначное число.\n");
                    goto Start;
                }

                string str = num.ToString();

                int x = Convert.ToInt32(str[0].ToString());
                int y = Convert.ToInt32(str[1].ToString());
                int z = Convert.ToInt32(str[2].ToString());
                int v = Convert.ToInt32(str[3].ToString());

                if (x + y == z + v)
                {
                    Console.WriteLine("\nПравда: Сумма первых двух цифр равна сумме двух последних цифр.");
                }
                else
                {
                    Console.WriteLine("\nЛожь: Суммы первых двух и последних двух цифр не равны.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: введенное число слишком большое.\n");
                goto Start;
            }
        }

        static void Z02()
        {
            Console.WriteLine("Задание 2.\n");
        Start:
            try
            {
                Console.WriteLine("Введите целое положительное трехзначное число:");
                int num = Convert.ToInt32(Console.ReadLine());

                if (num < 100 || num > 999)
                {
                    Console.WriteLine("\nОшибка: введите положительное трехзначное число.\n");
                    goto Start;
                }

                string str = num.ToString();

                int x = Convert.ToInt32(str[0].ToString());
                int y = Convert.ToInt32(str[1].ToString());
                int z = Convert.ToInt32(str[2].ToString());

                Console.WriteLine("\nИзменённое число: {0}{1}{2}", z, y, x);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: введенное число слишком большое.\n");
                goto Start;
            }
        }

        static void Z03()
        {
            Console.WriteLine("Задание 3.\n");
        Start:
            try
            {
                Console.WriteLine("Задайте число для A:");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте положительное число для B:");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте положительное число для C:");
                int C = Convert.ToInt32(Console.ReadLine());

                int count = 0;

                if (A > 0) count++;
                if (B > 0) count++;
                if (C > 0) count++;

                if (count == 1)
                {
                    Console.WriteLine("\nВысказывание истинно: ровно одно из чисел A, B, C положительное.");
                }
                else
                {
                    Console.WriteLine("\nВысказывание ложно: условие не выполнено.");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: введенное число слишком большое.\n");
                goto Start;
            }
        }

        static void Z04()
        {
            Console.WriteLine("Задание 4.\n");
        Start:
            try
            {
                Console.WriteLine("Задайте целое положительное число для A:");
                int A = Convert.ToInt32(Console.ReadLine());

                if (A <= 0)
                {
                    Console.WriteLine("\nОшибка: число A должно быть положительным.\n");
                    goto Start;
                }

                Console.WriteLine("Задайте целое положительное число для B:");
                int B = Convert.ToInt32(Console.ReadLine());

                if (B <= 0)
                {
                    Console.WriteLine("\nОшибка: число B должно быть положительным.\n");
                    goto Start;
                }

                if (A >= B)
                {
                    Console.WriteLine("\nОшибка: число А должно быть меньше B.\n");
                    goto Start;
                }

                int chet = 1;

                for (int i = A + 1; i < B; i++) // Проходим числа между A и B
                {
                    if (i % 2 == 0)
                    {
                        chet *= i;
                    }
                }

                if (chet == 1)
                {
                    Console.WriteLine("\nМежду {0} и {1} нет четных чисел.", A, B);
                }

                else
                {
                    Console.WriteLine("\nПроизведение всех четных чисел между {0} и {1}: {2}", A, B, chet);
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число.\n");
                goto Start;
            }

            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: введенное число слишком большое.\n");
                goto Start;
            }
        }

        static void Z05()
        {
            Console.WriteLine("Задание 5.\n");

            int N, M;

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите достоинство карты (6-14):");
                    N = Convert.ToInt32(Console.ReadLine());

                    if (N < 6 || N > 14)
                    {
                        Console.WriteLine("\nОшибка: достоинство карты должно быть от 6 до 14.\n");
                        continue;
                    }

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nОшибка: введите корректное число.\n");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Введите масть карты (1-4):");
                    M = Convert.ToInt32(Console.ReadLine());

                    if (M < 1 || M > 4)
                    {
                        Console.WriteLine("\nОшибка: масть карты должна быть от 1 до 4.\n");
                        continue;
                    }

                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nОшибка: введите корректное число.\n");
                }
            }


            string rank = "";
            switch (N)
            {
                case 6: rank = "шестерка"; break;
                case 7: rank = "семерка"; break;
                case 8: rank = "восьмерка"; break;
                case 9: rank = "девятка"; break;
                case 10: rank = "десятка"; break;
                case 11: rank = "валет"; break;
                case 12: rank = "дама"; break;
                case 13: rank = "король"; break;
                case 14: rank = "туз"; break;
            }

            string mast = "";
            switch (M)
            {
                case 1: mast = "пик"; break;
                case 2: mast = "треф"; break;
                case 3: mast = "бубен"; break;
                case 4: mast = "червей"; break;
            }

            Console.WriteLine("\nКарта: {0} {1}", rank, mast);
        }
    }
}
