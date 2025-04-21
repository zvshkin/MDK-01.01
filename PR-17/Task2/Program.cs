using System;
using Microsoft.Win32;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"PR_17\task02");
                int fahrenheit = (int)key.GetValue("fahrenheit");
                key.Close();

                if (fahrenheit == 0)
                {
                    throw new Exception("Температура не может быть нулевой.");
                }

                double celsius = (fahrenheit - 32) * 5.0 / 9.0;

                key = Registry.CurrentUser.CreateSubKey(@"PR_17\task02");
                key.SetValue("result2", celsius);
                key.Close();

                Console.WriteLine($"Результат записан в реестр: {celsius}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}