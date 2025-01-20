using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВАРИАНТ № А12/Б15"
                + "\n1. Даны три целых числа: A, B, C. Проверить истинность высказывания: «Каждое из чисел A, B, C положительное»."
                + "\n2. Ввести пять различных ненулевых целых чисел. Найти произведение трех наибольших чисел."
                + "\n3. Проверить истинность высказывания: \"Все цифры данного целого положительного четырехзначного числа различны\"."
                + "\n4. Из пяти целых различных ненулевых положительных и отрицательных чисел найти самое наименьшее число."
                + "\n5. Дан номер месяца N - целое положительное число в диапазоне от 1 до 12 (1 - январь, 2 - февраль, ..., 12 - декабрь). Вывести название соответствующего номера квартала (квартал – это четвертая часть года, один квартал = три месяца) (\"1 квартал\", \"2 квартал\", ..., \"4 квартал\").");

            otdel();
            Z01();
            otdel();
            Z02();
        }

        static void Z01()
        {
            Console.WriteLine("Задание 1.");

        Start: // Метка для возврата
            try
            {
                Console.WriteLine("Задайте целое число A:");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте целое число B:");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте целое число C:");
                int C = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nПроверка на истинность высказывания: «Каждое из чисел A, B, C положительное»\n");

                // Проверка на положительность чисел
                if (A > 0 && B > 0 && C > 0)
                {
                    Console.WriteLine("Высказывание истинно: все числа положительны.");
                }
                else
                {
                    Console.WriteLine("Высказывание ложно: не все числа положительны.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное целое число.\n");
                goto Start; // Возврат к метке Start
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введенное число слишком большое или слишком маленькое.\n");
                goto Start;
            }
        }
        
        static void otdel()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------\n");
        }

        static void Z02()
        {
            Console.WriteLine("Задание 2.");

        Start:
            try
            {
                Console.WriteLine("Задайте первое ненулевое целое число:");
                int A = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте второе ненулевое целое число:");
                int B = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте третье ненулевое целое число:");
                int C = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте четвёртое ненулевое целое число:");
                int D = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Задайте пятое ненулевое целое число:");
                int E = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nВычисление произведения трёх наибольших чисел.\n");

                // Проверка на ненулевые числа
                if (A == 0 || B == 0 || C == 0 || D == 0 || E == 0)
                {
                    Console.WriteLine("Ошибка: одно или несколько чисел равны нулю. Попробуйте снова.\n");
                    goto Start;
                }

                // Находим три наибольших числа
                int[] numbers = { A, B, C, D, E };
                Array.Sort(numbers); // Сортировка массива чисел по возрастанию

                int max1 = numbers[4];
                int max2 = numbers[3];
                int max3 = numbers[2];

                int umnozhenie = max1 * max2 * max3;

                Console.WriteLine("Три наибольших числа: {0}, {1}, {2}", max1, max2, max3);
                Console.WriteLine("Их произведение: {0}", umnozhenie);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введите корректное целое число.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Ошибка: введенное число слишком большое или слишком маленькое.\n");
                goto Start;
            }
        }
    }
}
