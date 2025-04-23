using System;
using Microsoft.Win32;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"PR_17\task05");
                string binary = (string)key.GetValue("binary");
                key.Close();

                int decimalValue = Convert.ToInt32(binary, 2);

                key = Registry.CurrentUser.CreateSubKey(@"PR_17\task05");
                key.SetValue("result5", decimalValue);
                key.Close();

                Console.WriteLine($"Результат записан в реестр: {decimalValue}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}