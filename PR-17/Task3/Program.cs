using System;
using System.Linq;
using Microsoft.Win32;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"PR_17\task03");
                string[] values = (string[])key.GetValue("array");
                key.Close();

                int[] array = Array.ConvertAll(values, int.Parse);

                int uniqueCount = array.Distinct().Count();

                key = Registry.CurrentUser.CreateSubKey(@"PR_17\task03");
                key.SetValue("result3", uniqueCount);
                key.Close();

                Console.WriteLine($"Результат записан в реестр: {uniqueCount}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}