using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВАРИАНТ № А15/Б12"
                + "\n1. Дано целое положительное четырехзначное число N (N>0). Проверить истинность высказывания: «Данное число N читается одинаково слева направо и справа налево»."
                + "\n2. Дано целое положительное трехзначное число. Вывести все числа, полученные при перестановке цифр исходного числа."
                + "\n3. Дан массив из N элементов. Поменять местами минимальный и максимальный элемент в массиве."
                + "\n4. Вводится строка-предложение. Подсчитать количество знаков препинания."
                + "\n5. Вводится строка с буквами и цифрами. Вывести сумму и произведение цифр строки.");

            Razdel();
            Console.WriteLine("Задание 1:");
            Z01();
            Console.WriteLine("Задание 1 выполнено. Результат записан в файл output1.txt");
            
            Razdel();
            Console.WriteLine("Задание 2:");
            Z02();
            Console.WriteLine("Задание 2 выполнено. Результат записан в файл output2.txt");
            
            Razdel();
            Console.WriteLine("Задание 3:");
            Z03();
            Console.WriteLine("Задание 3 выполнено. Результат записан в файл output3.txt");
            
            Razdel();
            Console.WriteLine("Задание 4:");
            Z04();
            Console.WriteLine("Задание 4 выполнено. Результат записан в файл output4.txt");
            
            Razdel();
            Console.WriteLine("Задание 5:");
            Z05();
            Console.WriteLine("Задание 5 выполнено. Результат записан в файл output5.txt");
            
            Razdel();
            Console.WriteLine("Все задания выполнены. Результаты сохранены в файлах output1.txt - output5.txt");
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }

        static void Razdel()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------\n");
        }

        static void Z01()
        {
            try
            {
                string[] lines = File.ReadAllLines("input1.txt");
                int N = Convert.ToInt32(lines[0]);

                if (N < 1000 || N > 9999)
                {
                    File.WriteAllText("output1.txt", "Ошибка: число должно быть четырехзначным положительным.");
                    return;
                }

                string numStr = N.ToString();
                string reversed = new string(numStr.Reverse().ToArray());
                string result = numStr == reversed 
                    ? $"Высказывание истинно: число {N} является палиндромом."
                    : $"Высказывание ложно: число {N} не является палиндромом.";

                File.WriteAllText("output1.txt", result);
            }
            catch (Exception ex)
            {
                File.WriteAllText("output1.txt", $"Ошибка: {ex.Message}");
            }
        }

        static void Z02()
        {
            try
            {
                string[] lines = File.ReadAllLines("input2.txt");
                int num = Convert.ToInt32(lines[0]);

                if (num < 100 || num > 999)
                {
                    File.WriteAllText("output2.txt", "Ошибка: число должно быть трехзначным.");
                    return;
                }

                string numStr = num.ToString();
                char[] digits = numStr.ToCharArray();

                var permutations = new System.Text.StringBuilder();
                for (int i = 0; i < 3; i++)
                    for (int j = 0; j < 3; j++)
                        for (int k = 0; k < 3; k++)
                            if (i != j && j != k && i != k)
                                permutations.AppendLine($"{digits[i]}{digits[j]}{digits[k]}");

                File.WriteAllText("output2.txt", permutations.ToString());
            }
            catch (Exception ex)
            {
                File.WriteAllText("output2.txt", $"Ошибка: {ex.Message}");
            }
        }

        static void Z03()
        {
            try
            {
                string[] lines = File.ReadAllLines("input3.txt");
                int n = Convert.ToInt32(lines[0]);
                
                if (n <= 25)
                {
                    File.WriteAllText("output3.txt", "Ошибка: размер массива должен быть больше 25.");
                    return;
                }

                int[] array = lines[1].Split(' ').Select(int.Parse).ToArray();
                if (array.Length != n)
                {
                    File.WriteAllText("output3.txt", "Ошибка: количество элементов не соответствует указанному размеру.");
                    return;
                }

                int minIndex = Array.IndexOf(array, array.Min());
                int maxIndex = Array.IndexOf(array, array.Max());

                int temp = array[minIndex];
                array[minIndex] = array[maxIndex];
                array[maxIndex] = temp;

                string result = string.Join(" ", array);
                File.WriteAllText("output3.txt", result);
            }
            catch (Exception ex)
            {
                File.WriteAllText("output3.txt", $"Ошибка: {ex.Message}");
            }
        }

        static void Z04()
        {
            try
            {
                string input = File.ReadAllText("input4.txt");

                if (input.Length < 40)
                {
                    File.WriteAllText("output4.txt", "Ошибка: длина строки должна быть не менее 40 символов.");
                    return;
                }

                char[] punctuation = { '.', ',', '!', '?', ':', ';', '-', '(', ')', '"', '\'' };
                int count = input.Count(c => punctuation.Contains(c));

                File.WriteAllText("output4.txt", $"Количество знаков препинания в строке: {count}");
            }
            catch (Exception ex)
            {
                File.WriteAllText("output4.txt", $"Ошибка: {ex.Message}");
            }
        }

        static void Z05()
        {
            try
            {
                string input = File.ReadAllText("input5.txt");

                if (input.Length < 40)
                {
                    File.WriteAllText("output5.txt", "Ошибка: длина строки должна быть не менее 40 символов.");
                    return;
                }

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

                var result = new System.Text.StringBuilder();
                if (hasDigits)
                {
                    result.AppendLine($"Сумма цифр: {sum}");
                    result.AppendLine($"Произведение цифр: {product}");
                }
                else
                {
                    result.Append("В строке нет цифр.");
                }

                File.WriteAllText("output5.txt", result.ToString());
            }
            catch (Exception ex)
            {
                File.WriteAllText("output5.txt", $"Ошибка: {ex.Message}");
            }
        }
    }
}