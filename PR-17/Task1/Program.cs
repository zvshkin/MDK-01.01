using System;
using Microsoft.Win32;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"PR_17\task01");
                int number = (int)key.GetValue("number");
                key.Close();

                if (number < 100 || number > 999)
                {
                    throw new Exception("Число должно быть трехзначным.");
                }

                int sum = (number / 100) + ((number / 10) % 10) + (number % 10);

                bool isOdd = sum % 2 != 0;

                key = Registry.CurrentUser.CreateSubKey(@"PR_17\task01");
                key.SetValue("result1", isOdd);
                key.Close();

                Console.WriteLine($"Результат записан в реестр: {isOdd}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}