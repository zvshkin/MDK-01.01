using System;
using System.Linq;

namespace PR_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Задание 1: Перевод температуры из Фаренгейта в Цельсий
                int Tf = GetValidIntegerInput("Задание 1: Введите температуру в градусах Фаренгейта (целое ненулевое число):", "nonZero");
                Console.WriteLine($"Температура в градусах Цельсия: {Task01.ConvertFahrenheitToCelsius(Tf):F2}");

                // Задание 2: Координаты точки во второй четверти
                int X = GetValidIntegerInput("\nЗадание 2: Введите координату X (целое число):");
                int Y = GetValidIntegerInput("Введите координату Y (целое число):");

                if (Task02.IsInSecondQuadrant(X, Y))
                {
                    Console.WriteLine("Точка лежит во второй четверти.");
                }
                else
                {
                    Console.WriteLine("Точка не лежит во второй четверти.");
                }

                // Задание 3: Обработка массива
                int N = GetValidIntegerInput("\nЗадание 3: Введите размер массива (целое положительное число):", "positive");
                int[] array = new int[N];

                Console.WriteLine("Выберите способ заполнения массива:");
                Console.WriteLine("1 - Ввести элементы вручную");
                Console.WriteLine("2 - Заполнить массив случайными числами");
                int choice = GetValidIntegerInput("Введите номер варианта (1 или 2):");

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Введите элементы массива через пробел:");
                        while (true)
                        {
                            string[] input = Console.ReadLine().Split();
                            if (input.Length == N && input.All(x => int.TryParse(x, out _)))
                            {
                                for (int i = 0; i < N; i++) array[i] = int.Parse(input[i]);
                                break;
                            }
                            Console.WriteLine($"Ошибка: Введите ровно {N} целых чисел через пробел.");
                        }
                        break;

                    case 2:
                        Random random = new Random();
                        Console.WriteLine("Массив заполняется случайными числами (-50; 50)...");
                        for (int i = 0; i < N; i++)
                        {
                            array[i] = random.Next(-50, 51);
                        }
                        Console.WriteLine("Сгенерированный массив: " + string.Join(", ", array));
                        break;

                    default:
                        Console.WriteLine("Ошибка: Неверный выбор. Массив не заполнен.");
                        return;
                }

                Console.WriteLine($"Результат обработки массива: {Task03.ProcessArray(array)}");

                // Задание 4: Проверка палиндрома
                int K = GetValidIntegerInput("\nЗадание 4: Введите четырехзначное число:", "fourDigit");

                if (Task04.IsPalindrome(K))
                {
                    Console.WriteLine("Число является палиндромом.");
                }
                else
                {
                    Console.WriteLine("Число не является палиндромом.");
                }

                // Задание 5: Подсчет чисел в строке
                Console.WriteLine("\nЗадание 5: Введите строку:");
                string str = Console.ReadLine();
                var (count, sum) = Task05.CountAndSumNumbers(str);
                Console.WriteLine($"Количество чисел: {count}, Сумма чисел: {sum}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        static int GetValidIntegerInput(string prompt, string validationType = "")
        {
            int result;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    if (validationType == "nonZero" && result == 0)
                    {
                        Console.WriteLine("Ошибка: Введенное значение не должно быть нулевым. Попробуйте снова.");
                        continue;
                    }
                    if (validationType == "positive" && result <= 0)
                    {
                        Console.WriteLine("Ошибка: Введенное значение должно быть положительным. Попробуйте снова.");
                        continue;
                    }
                    if (validationType == "fourDigit" && (result < 1000 || result >= 10000))
                    {
                        Console.WriteLine("Ошибка: Введенное значение должно быть четырехзначным числом. Попробуйте снова.");
                        continue;
                    }

                    return result;
                }

                Console.WriteLine("Ошибка: Введенное значение некорректно. Попробуйте снова.");
            }
        }
    }
}