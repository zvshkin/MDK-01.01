using System;
using System.Linq;

namespace PR_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("ВАРИАНТ № А15/Б12\n");
                Console.WriteLine("1. Проверить истинность высказывания: \"Цифры данного целого положительного четырехзначного числа образуют возрастающую последовательность\"");
                Console.WriteLine("2. Дан массив из N элементов. Поменять порядок следования его элементов на обратный. Вычислить сумму и произведение элементов.");
                Console.WriteLine("3. Вводится строка слов, разделенных подчеркиваниями. Найти все слова, начинающиеся на гласную букву.");
                Console.WriteLine("4. Написать функцию Min5(A, B, C, D, E), возвращающую минимальное из 5 чисел.");
                Console.WriteLine("5. Написать функцию Calc(A, B, Op), выполняющую арифметические операции над числами A и B согласно параметру Op.");
                Console.WriteLine("0. Выход\n");

                Console.WriteLine("\n----------------------------------------------\n");

                Console.Write("Выберите задание (0-5): ");
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
                    default:
                        Console.WriteLine("\nОшибка: выберите число от 0 до 5.");
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }

        // Функция для задания 1
        static bool ProverkaPosled(int number)
        {
            string numStr = number.ToString();
            for (int i = 0; i < numStr.Length - 1; i++)
            {
                if (numStr[i] >= numStr[i + 1])
                    return false;
            }
            return true;
        }

        static void Zadanie1()
        {
            Console.WriteLine("\nЗадание 1.\n");
            while (true)
            {
                Console.Write("Введите четырехзначное число: ");
                if (!int.TryParse(Console.ReadLine(), out int number) ||
                    number < 1000 || number > 9999)
                {
                    Console.WriteLine("\nОшибка: введите четырехзначное положительное число.\n");
                    continue;
                }

                if (ProverkaPosled(number))
                {
                    Console.WriteLine($"\nЦифры в числе {number} расположены в порядке возрастания.");
                }
                else 
                {
                    Console.WriteLine($"\nЦифры в числе {number} не расположены в порядке возрастания.");
                }
                break;
            }
        }

        // Функция для задания 2
        static (int[] massiv, long summa, long proizved) PerevernutMassiv(int[] massiv)
        {
            Array.Reverse(massiv);
            return (massiv, massiv.Sum(x => (long)x), massiv.Aggregate(1L, (a, b) => a * b)); // massiv.Aggregate(1L ((начальное значение 1 типа long)), (a, b) => a * b (для каждой пары чисел выполняется умножение))
        }

        static void Zadanie2()
        {
            Console.WriteLine("\nЗадание 2.\n");
            while (true)
            {
                Console.Write("Введите размер массива (N > 25): ");
                if (!int.TryParse(Console.ReadLine(), out int n) || n <= 25)
                {
                    Console.WriteLine("\nОшибка: размер массива должен быть больше 25.\n");
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
                        array[i] = rand.Next(-100, 101);

                    Console.WriteLine("\nСгенерированный массив:");
                    Console.WriteLine(string.Join(" ", array));
                }

                var (reversed, sum, product) = PerevernutMassiv(array);
                
                Console.WriteLine("\nПеревернутый массив:");
                Console.WriteLine(string.Join(" ", reversed));
                Console.WriteLine($"\nСумма элементов: {sum}");
                Console.WriteLine($"Произведение элементов: {product}");
                break;
            }
        }

        // Функция для задания 3
        static string[] NaitiSlovaGlasnye(string stroka)
        {
            char[] glasnye = { 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я',
                            'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' };
            return stroka.Split('_')
                       .Where(word => word.Length > 0 && glasnye.Contains(word[0]))
                       .ToArray();
        }

        static void Zadanie3()
        {
            Console.WriteLine("\nЗадание 3.\n");
            while (true)
            {
                Console.WriteLine("Введите строку слов, разделенных подчеркиваниями (минимум 40 символов):");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input) || input.Length < 40)
                {
                    Console.WriteLine("\nОшибка: строка должна содержать минимум 40 символов.\n");
                    continue;
                }

                string[] vowelWords = NaitiSlovaGlasnye(input);
                Console.WriteLine("\nСлова, начинающиеся на гласную букву:");
                foreach (string word in vowelWords)
                {
                    Console.WriteLine(word);
                }
                break;
            }
        }

        // Функция для задания 4
        static int NaitiMin5(int a, int b, int c, int d, int e)
        {
            return Math.Min(Math.Min(Math.Min(Math.Min(a, b), c), d), e);
        }

        static void Zadanie4()
        {
            Console.WriteLine("\nЗадание 4.\n");
            int[] numbers = new int[5];
            string[] labels = { "A", "B", "C", "D", "E" };

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write($"Введите число {labels[i]}: ");
                    if (int.TryParse(Console.ReadLine(), out numbers[i]))
                        break;
                    Console.WriteLine("Ошибка: введите корректное целое число.");
                }
            }

            int min = NaitiMin5(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);
            Console.WriteLine($"\nМинимальное число: {min}");
        }

        // Функция для задания 5
        static int Vychislit(int a, int b, int op)
        {
            switch (op)
            {
                case 1: return a - b;
                case 2: return a * b;
                case 3:
                    if (b == 0)
                        throw new DivideByZeroException();
                    return a / b;
                case 4: return a + b;
                default:
                    throw new ArgumentException("Неверный код операции");
            }
        }

        static void Zadanie5()
        {
            Console.WriteLine("\nЗадание 5.\n");
            while (true)
            {
                try
                {
                    Console.Write("Введите первое число (A): ");
                    if (!int.TryParse(Console.ReadLine(), out int a))
                    {
                        Console.WriteLine("Ошибка: введите корректное целое число.");
                        continue;
                    }

                    Console.Write("Введите второе число (B): ");
                    if (!int.TryParse(Console.ReadLine(), out int b))
                    {
                        Console.WriteLine("Ошибка: введите корректное целое число.");
                        continue;
                    }

                    Console.WriteLine("\nВыберите операцию:");
                    Console.WriteLine("1 - Вычитание");
                    Console.WriteLine("2 - Умножение");
                    Console.WriteLine("3 - Деление");
                    Console.WriteLine("4 - Сложение");

                    Console.Write("\nВаш выбор: ");
                    if (!int.TryParse(Console.ReadLine(), out int op) || op < 1 || op > 4)
                    {
                        Console.WriteLine("Ошибка: выберите число от 1 до 4.");
                        continue;
                    }

                    int result = Vychislit(a, b, op);
                    Console.WriteLine($"\nРезультат: {result}");
                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Ошибка: деление на ноль.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}