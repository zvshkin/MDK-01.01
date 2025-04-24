using Microsoft.Win32;
using System;
using System.Linq;

namespace PR_17
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Выберите задание (1-5):");
                int taskNumber = int.Parse(Console.ReadLine());

                switch (taskNumber)
                {
                    case 1:
                        Task01();
                        break;

                    case 2:
                        Task02();
                        break;

                    case 3:
                        Task03();
                        break;

                    case 4:
                        Task04();
                        break;

                    case 5:
                        Task05();
                        break;

                    default:
                        Console.WriteLine("Неверный номер задания.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }

        // Задание 1: Проверка истинности высказывания
        static void Task01()
        {
            // Чтение данных из реестра
            int number;
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17\task01"))
            {
                number = (int)(key.GetValue("number", 100)); // Значение по умолчанию: 100
            }

            // Выполнение логики
            bool result = IsOddDigitSum(number);

            // Сохранение результата в реестр
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17\task01"))
            {
                key.SetValue("result1", result);
            }

            Console.WriteLine($"Результат записан в реестр: {result}");
        }

        static bool IsOddDigitSum(int number)
        {
            if (number < 100 || number > 999)
                throw new ArgumentException("Число должно быть трехзначным.");
            int sum = (number / 100) + ((number / 10) % 10) + (number % 10);
            return sum % 2 != 0;
        }

        // Задание 2: Перевод температуры из Фаренгейта в Цельсий
        static void Task02()
        {
            // Чтение данных из реестра
            int Tf;
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17\task02"))
            {
                Tf = (int)(key.GetValue("temperatureFahrenheit", 32)); // Значение по умолчанию: 32
            }

            // Выполнение логики
            double Tc = ConvertFahrenheitToCelsius(Tf);

            // Сохранение результата в реестр
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17\task02"))
            {
                key.SetValue("result2", Tc);
            }

            Console.WriteLine($"Температура в градусах Цельсия: {Tc:F2}");
        }

        static double ConvertFahrenheitToCelsius(int Tf)
        {
            if (Tf == 0)
                throw new ArgumentException("Температура не может быть равна 0.");
            return (Tf - 32) * 5.0 / 9;
        }

        // Задание 3: Количество различных элементов в массиве
        static void Task03()
        {
            // Чтение данных из реестра
            int[] array;
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17\task03"))
            {
                array = (int[])(key.GetValue("array", new int[] { 1, 2, 2, 3 })); // Значение по умолчанию: {1, 2, 2, 3}
            }

            // Выполнение логики
            int uniqueCount = CountUniqueElements(array);

            // Сохранение результата в реестр
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17\task03"))
            {
                key.SetValue("result3", uniqueCount);
            }

            Console.WriteLine($"Количество различных элементов: {uniqueCount}");
        }

        static int CountUniqueElements(int[] array)
        {
            if (array.Length == 0)
                throw new ArgumentException("Массив не должен быть пустым.");
            return array.Distinct().Count();
        }

        // Задание 4: Проверка високосного года
        static void Task04()
        {
            // Чтение данных из реестра
            int year;
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17\task04"))
            {
                year = (int)(key.GetValue("year", 2023)); // Значение по умолчанию: 2023
            }

            // Выполнение логики
            bool isLeapYear = IsLeapYear(year);

            // Сохранение результата в реестр
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17\task04"))
            {
                key.SetValue("result4", isLeapYear);
            }

            Console.WriteLine($"Результат записан в реестр: {isLeapYear}");
        }

        static bool IsLeapYear(int year)
        {
            if (year <= 0)
                throw new ArgumentException("Год должен быть положительным числом.");
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        // Задание 5: Преобразование двоичной строки в десятичную
        static void Task05()
        {
            // Чтение данных из реестра
            string binaryString;
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17\task05"))
            {
                binaryString = (string)(key.GetValue("binaryString", "1010")); // Значение по умолчанию: "1010"
            }

            // Выполнение логики
            int decimalValue = ConvertBinaryToDecimal(binaryString);

            // Сохранение результата в реестр
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"PR_17\task05"))
            {
                key.SetValue("result5", decimalValue);
            }

            Console.WriteLine($"Десятичное значение: {decimalValue}");
        }

        static int ConvertBinaryToDecimal(string binaryString)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(binaryString, "^[01]+$"))
                throw new ArgumentException("Строка должна содержать только двоичные цифры (0 и 1).");
            return Convert.ToInt32(binaryString, 2);
        }
    }
}
