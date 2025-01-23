using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВАРИАНТ № А15/Б12"
                + "\n1. Даны два целых положительных числа: A, B. Проверить истинность высказывания: «Каждое из чисел A и B нечетное»."
                + "\n2. Задано целое положительное четырехзначное число N (N > 0). Найти разницу между произведениями первых двух и последних двух его цифр."
                + "\n3. Дан массив ненулевых целых чисел, признак его завершения - число 0. Вывести на экран все положительные нечетные числа из данного набора, а строкой ниже вывести их сумму. Если требуемые числа в наборе отсутствуют, то вывести значение -1."
                + "\n4. Дан целочисленный массив, состоящий из N элементов и целые числа K и L (1 < K <= L <= N). Найти сумму всех элементов массива, кроме элементов с номерами от K до L включительно."
                + "\n5. Дан целочисленный массив, признак его завершения - число 0. Размер массива может быть разный. Вывести сумму всех положительных четных чисел из данного массива. Если требуемые числа в наборе отсутствуют, то вывести 0.");

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
            ChisloA:
                Console.Write("Задайте целое положительное число A: ");
                int A = Convert.ToInt32(Console.ReadLine());
                if (A < 0)
                {
                    goto ChisloA;
                }

            ChisloB:
                Console.Write("Задайте целое положительное число B: ");
                int B = Convert.ToInt32(Console.ReadLine());
                if (B < 0)
                {
                    goto ChisloB;
                }

                if (A % 2 != 0 && B % 2 != 0)
                {
                    Console.WriteLine("\nВысказывание \"Каждое из чисел A ({0}) и B ({1}) нечетное\" - Истина", A, B);
                }

                else
                {
                    Console.WriteLine("\nВысказывание \"Каждое из чисел A ({0}) и B ({1}) нечетное\" - Ложь", A, B);
                }
            }

            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число. Начните задание заново.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: введенное число слишком большое. Начните задание заново.\n");
                goto Start;
            }
        }

        static void Z02()
        {
            Console.WriteLine("Задание 2.\n");

        Start:
            try
            {
                Console.Write("Введите целое положительное четырехзначное число N (N > 0): ");
                int N = Convert.ToInt32(Console.ReadLine());

                if (N < 1000 || N > 9999)
                {
                    Console.WriteLine("\nОшибка: введите положительное четырёхзначное число.\n");
                    goto Start;
                }

                string str = N.ToString();

                int x = Convert.ToInt32(str[0].ToString());
                int y = Convert.ToInt32(str[1].ToString());
                int z = Convert.ToInt32(str[2].ToString());
                int k = Convert.ToInt32(str[3].ToString());

                int v = x * y - z * k;

                Console.WriteLine("\nРазница между произведениями первых двух ({0}{1}) и последних двух ({2}{3}) цифр числа N = {4} ", x, y, z, k, v);

            }

            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число. Начните задание заново.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: введенное число слишком большое. Начните задание заново.\n");
                goto Start;
            }
        }

        static void Z03()
        {
            Console.WriteLine("Задание 3.\n");

        Start:
            try
            {
                Console.Write("Введите размер массива (минимум 25 элементов): ");
                int size = Convert.ToInt32(Console.ReadLine());

                if (size < 25)
                {
                    Console.WriteLine("\nОшибка: размер массива должен быть целым числом и не менее 25. Попробуйте заново.\n");
                    goto Start;
                }

                int[] array = new int[size];

                Console.WriteLine("\nВыберите способ заполнения массива:");
                Console.WriteLine("1 - Ввести элементы вручную");
                Console.WriteLine("2 - Заполнить массив автоматически");
            Vibor:
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("\nВведите элементы массива (число 0 завершает ввод):");
                    for (int i = 0; i < size; i++)
                    {
                        Console.Write("Элемент {0}: ", i);
                        int input = Convert.ToInt32(Console.ReadLine());
                        if (input == 0)
                        {
                            break;
                        }
                        array[i] = input;
                    }
                }
                else if (choice == "2")
                {
                    Random rand = new Random();
                    for (int i = 0; i < size; i++)
                    {
                        array[i] = rand.Next(-50, 51);
                    }
                    Console.WriteLine("Массив заполнен автоматически.");
                }
                else
                {
                    Console.WriteLine("Неверный выбор. Попробуйте заново.");
                    goto Vibor;
                }

                int[] positiveOdd = Array.FindAll(array, num => num > 0 && num % 2 != 0);
                int sum = 0;

                Console.WriteLine("\nПоложительные нечетные числа:");
                for (int i = 0; i < positiveOdd.Length; i++)
                {
                    Console.Write(positiveOdd[i] + " ");
                    sum += positiveOdd[i];
                }

                if (positiveOdd.Length > 0)
                {
                    Console.WriteLine("\nСумма положительных нечетных чисел: {0}", sum);
                }
                else
                {
                    Console.WriteLine("Нет положительных нечетных чисел.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число. Начните задание заново.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: введенное число слишком большое. Начните задание заново.\n");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nПроизошла ошибка: {0}. Начните задание заново.\n", ex.Message);
                goto Start;
            }
        }

        static void Z04()
        {
            Console.WriteLine("Задание 4.\n");

        Start:
            try
            {
                Console.Write("Введите размер массива (минимум 25 элементов): ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n < 25)
                {
                    Console.WriteLine("\nОшибка: размер массива должен быть не менее 25. Попробуйте заново.\n");
                    goto Start;
                }

                int[] array = new int[n];

                Console.WriteLine("\nВыберите способ заполнения массива:");
                Console.WriteLine("1 - Ввести элементы вручную");
                Console.WriteLine("2 - Заполнить массив автоматически");

            Vibor:
                Console.Write("Ваш выбор: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("\nВведите элементы массива:");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Элемент {0}: ", i);
                        array[i] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                else if (choice == 2)
                {
                    Random rand = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        array[i] = rand.Next(-100, 101);
                    }
                    Console.WriteLine("\nМассив заполнен автоматически.");
                }
                else
                {
                    Console.WriteLine("\nНеверный выбор. Попробуйте снова.\n");
                    goto Vibor;
                }

                Console.Write("\nВведите K (1 < K <= N): ");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите L (K <= L <= N): ");
                int l = Convert.ToInt32(Console.ReadLine());

                if (k <= 1 || k > l || l > n)
                {
                    Console.WriteLine("\nОшибка: должно выполняться условие 1 < K <= L <= N. Попробуйте снова.\n");
                    goto Start;
                }

                int sum = 0;
                for (int i = 0; i < n; i++)
                {
                    if (i + 1 < k || i + 1 > l)
                    {
                        sum += array[i];
                    }
                }

                Console.WriteLine("\nМассив:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(array[i] + " ");
                }

                Console.WriteLine("\n\nСумма элементов массива, кроме элементов с номерами от {0} до {1}: {2}", k, l, sum);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число. Начните задание заново.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: введенное число слишком большое. Начните задание заново.\n");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nПроизошла ошибка: {0}. Начните задание заново.\n", ex.Message);
                goto Start;
            }
        }

        static void Z05()
        {
            Console.WriteLine("Задание 5.\n");

        Start:
            try
            {
                Console.Write("Введите количество элементов массива (минимум 25 элементов): ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n < 25)
                {
                    Console.WriteLine("\nОшибка: размер массива должен быть не менее 25. Попробуйте заново.\n");
                    goto Start;
                }

                int[] array = new int[n];

                Console.WriteLine("\nВыберите способ заполнения массива:");
                Console.WriteLine("1 - Ввести элементы вручную");
                Console.WriteLine("2 - Заполнить массив автоматически");
            Vibor:
                Console.Write("Ваш выбор: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.WriteLine("\nВведите элементы массива (введите 0, чтобы завершить ввод):");
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write("Элемент {0}: ", i + 1);
                        int input = Convert.ToInt32(Console.ReadLine());
                        if (input == 0)
                        {
                            // Array.Resize(ref array, i); - без изменения размера все оставшиеся элементы будут равны нулю
                            break;
                        }
                        array[i] = input;
                    }
                }
                else if (choice == "2")
                {
                    Random rand = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        array[i] = rand.Next(-50, 51);
                    }
                    Console.WriteLine("Массив заполнен автоматически.");
                }
                else
                {
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    goto Vibor;
                }

                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0 && array[i] % 2 == 0)
                    {
                        sum += array[i];
                    }
                }

                Console.WriteLine("\nМассив:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("{0} ", array[i]);
                }

                Console.WriteLine("\n\nСумма положительных четных чисел: {0}", sum);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное целое число. Начните задание заново.\n");
                goto Start;
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nОшибка: введенное число слишком большое. Начните задание заново.\n");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nПроизошла ошибка: {0}. Начните задание заново.\n", ex.Message);
                goto Start;
            }
        }
    }
}
