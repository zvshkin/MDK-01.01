using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PR_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВАРИАНТ № А15/Б12"
                + "\n1. Проверить истинность высказывания: \"Квадратное уравнение A·x2 + B·x + C = 0 с данными коэффициентами A (A не равно 0), B, C имеет ровно один вещественный корень\"."
                + "\n2. Дан целочисленный массив, состоящий из N элементов (N > 0). После каждого отрицательного элемента массива вставить элемент с нулевым значением."
                + "\n3. Вводится строка, состоящая из слов, разделенных подчеркиваниями. Определить количество слов, которые начинаются и заканчиваются одной и той же буквой."
                + "\n4. Вводится строка вида «цифра_цифра_цифра_цифра», где «_» - это «+» или «-». Вывести значение выражения."
                + "\n5. Вводится строка с буквами и цифрами. Вывести сумму и произведение цифр строки.");

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
                Console.Write("Введите коэффициент A (не равный 0): ");
                double a = Convert.ToDouble(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("\nОшибка: коэффициент A не может быть равен 0.\n");
                    goto Start;
                }

                Console.Write("Введите коэффициент B: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите коэффициент C: ");
                double c = Convert.ToDouble(Console.ReadLine());

                double discriminant = b * b - 4 * a * c;

                if (discriminant == 0)
                {
                    Console.WriteLine("\nВысказывание истинно: уравнение имеет ровно один корень.");
                }
                else
                {
                    Console.WriteLine("\nВысказывание ложно: уравнение имеет два корня или не имеет корней.");
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
                    for (int i = 0; i < n; i++)
                    {
                        array[i] = rand.Next(-10, 11);
                    }
                }

                int negCount = array.Count(x => x < 0);
                int[] newArray = new int[n + negCount];

                int j = 0;
                for (int i = 0; i < n; i++)
                {
                    newArray[j] = array[i];
                    j++;
                    if (array[i] < 0)
                    {
                        newArray[j] = 0;
                        j++;
                    }
                }

                Console.WriteLine("\n\nМассив после вставки нулей:");
                foreach (int num in newArray)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("\nОшибка: введите корректное число.\n");
                goto Start;
            }
        }

        static void Z03()
        {
            Console.WriteLine("Задание 3.\n");
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

        static void Z04()
        {
            Console.WriteLine("Задание 4.\n");
        Start:
            try
            {
                Console.WriteLine("Введите арифметическое выражение (например, 4+7-2+5):");
                string expression = Console.ReadLine();

                if (!expression.All(c => char.IsDigit(c) || c == '+' || c == '-'))
                {
                    Console.WriteLine("\nОшибка: выражение должно содержать только цифры и знаки +/-\n");
                    goto Start;
                }

                int result = expression[0] - '0';
                for (int i = 1; i < expression.Length; i += 2)
                {
                    if (i + 1 < expression.Length)
                    {
                        int digit = expression[i + 1] - '0';
                        if (expression[i] == '+')
                            result += digit;
                        else if (expression[i] == '-')
                            result -= digit;
                    }
                }

                Console.WriteLine($"\nРезультат: {result}");
            }
            catch (Exception)
            {
                Console.WriteLine("\nОшибка: некорректное выражение.\n");
                goto Start;
            }
        }

        static void Z05()
        {
            Console.WriteLine("Задание 5.\n");

            Console.WriteLine("Введите строку, содержащую буквы и цифры:");
            string input = Console.ReadLine();

            int sum = 0;
            double product = 1;
            bool hasDigits = false;

            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    int digit = c - '0';
                    sum += digit;
                    product *= digit;
                    hasDigits = true;
                }
            }

            if (hasDigits)
            {
                Console.WriteLine($"\nСумма цифр: {sum}");
                Console.WriteLine($"Произведение цифр: {product}");
            }
            else
            {
                Console.WriteLine("\nВ строке нет цифр.");
            }
        }
    }
}