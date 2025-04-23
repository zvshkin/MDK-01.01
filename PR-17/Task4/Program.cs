using System;
using Microsoft.Win32;

namespace Task4
{
    class Program
    {
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }

        static void Main(string[] args)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"PR_17\task04");
                int year = (int)key.GetValue("year");
                key.Close();

                if (year <= 0)
                {
                    throw new Exception("Год должен быть положительным числом.");
                }

                bool isLeap = IsLeapYear(year);

                key = Registry.CurrentUser.CreateSubKey(@"PR_17\task04");
                key.SetValue("result4", isLeap);
                key.Close();

                Console.WriteLine($"Результат записан в реестр: {isLeap}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}