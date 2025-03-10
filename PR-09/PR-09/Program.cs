using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PR_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Проверить истинность высказывания: \"Все цифры данного целого положительного пятизначного числа введенного с клавиатуры различны\".");
            Console.WriteLine("2. Дан целочисленный массив, состоящий из N элементов (N > 0). Преобразовать массив, прибавив к четным числам первый элемент. Первый и последний элементы массива не изменять. Вывести новый полученный массив.");
            Console.WriteLine("3. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). Длина строки может быть разной. Найти и вывести все слова, которые начинающиеся только на цифру 3 или 7, а заканчиваются только цифрой 1.");
            Console.WriteLine("4. Написать функцию int MinDigit(K) целого типа, возвращающую минимальную цифру в целом положительном числе K.");
            Console.WriteLine("5. Написать функцию int Min3Of5Mul(A, B, C, D, E) целого типа, возвращающую произведение трех самых минимальных из 5-ти своих аргументов (параметры A, B, C, D, E - целые числа).");

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

        /// Задание 1: Проверка различности цифр пятизначного числа
        static void Z01()
        {
            try
            {
                string[] lines = File.ReadAllLines("input1.txt");

                if (lines.Length == 0)
                {
                    File.WriteAllText("output1.txt", "Ошибка: файл input1.txt пуст.");
                    return;
                }

                if (!int.TryParse(lines[0], out int number))
                {
                    File.WriteAllText("output1.txt", "Ошибка: содержимое файла input1.txt не является целым числом.");
                    return;
                }

                if (number < 10000 || number > 99999)
                {
                    File.WriteAllText("output1.txt", "Ошибка: число должно быть пятизначным и положительным.");
                    return;
                }

                string numStr = number.ToString();

                bool vse_razlichnie = true;
                for (int i = 0; i < numStr.Length; i++)
                {
                    for (int j = i + 1; j < numStr.Length; j++)
                    {
                        if (numStr[i] == numStr[j])
                        {
                            vse_razlichnie = false;
                            break;
                        }
                    }
                    if (!vse_razlichnie) break;
                }

                string result;
                if (vse_razlichnie)
                {
                    result = "Все цифры числа " + number + " различны.";
                }
                else
                {
                    result = "В числе " + number + " есть повторяющиеся цифры.";
                }

                File.WriteAllText("output1.txt", result);
            }
            catch (Exception ex)
            {
                File.WriteAllText("output1.txt", "Ошибка в Z01: " + ex.Message);
            }
        }

        /// Задание 2: Прибавить к четным элементам массива первый элемент (кроме первого и последнего).
        static void Z02()
        {
            try
            {
                string[] lines = File.ReadAllLines("input2.txt");
                if (lines.Length == 0)
                {
                    File.WriteAllText("output2.txt", "Ошибка: файл input2.txt пуст.");
                    return;
                }

                string[] strNumbers = lines[0].Split(' ');
                int[] array = new int[strNumbers.Length];

                for (int i = 0; i < strNumbers.Length; i++)
                {
                    if (!int.TryParse(strNumbers[i], out array[i]))
                    {
                        File.WriteAllText("output2.txt", "Ошибка: '" + strNumbers[i] + "' не является целым числом.");
                        return;
                    }
                }

                if (array.Length <= 25)
                {
                    File.WriteAllText("output2.txt", "Ошибка: размер массива должен быть больше 25 элементов.");
                    return;
                }

                int firstElement = array[0];

                for (int i = 1; i < array.Length - 1; i++)
                {
                    if (array[i] % 2 == 0)
                    {
                        array[i] = array[i] + firstElement;
                    }
                }

                string result = "";
                for (int i = 0; i < array.Length; i++)
                {
                    result += array[i] + " ";
                }

                File.WriteAllText("output2.txt", result);
            }
            catch (Exception ex)
            {
                File.WriteAllText("output2.txt", "Ошибка в Z02: " + ex.Message);
            }
        }

        /// Задание 3: Найти слова, начинающиеся на 3 или 7 и заканчивающиеся на 1.
        static void Z03()
        {
            try
            {
                string text = File.ReadAllText("input3.txt");

                if (string.IsNullOrEmpty(text) || text.Length < 50)
                {
                    File.WriteAllText("output3.txt", "Ошибка: строка пуста или её длина меньше 50 символов.");
                    return;
                }

                string[] words = text.Split('_');

                List<string> foundWords = new List<string>();

                foreach (string word in words)
                {
                    if (word.Length > 0 && (word[0] == '3' || word[0] == '7') && word[word.Length - 1] == '1')
                    {
                        foundWords.Add(word);
                    }
                }

                if (foundWords.Count > 0)
                {
                    string result = "";
                    foreach (string word in foundWords)
                    {
                        result += word + Environment.NewLine;
                    }
                    File.WriteAllText("output3.txt", result);
                }
                else
                {
                    File.WriteAllText("output3.txt", "Слова, удовлетворяющие условию, не найдены.");
                }
            }
            catch (Exception ex)
            {
                File.WriteAllText("output3.txt", "Ошибка в Z03: " + ex.Message);
            }
        }

        /// Задание 4: Найти минимальную цифру в числе.
        static void Z04()
        {
            try
            {
                string[] lines = File.ReadAllLines("input4.txt");
                if (lines.Length == 0)
                {
                    File.WriteAllText("output4.txt", "Ошибка: файл input4.txt пуст.");
                    return;
                }

                if (!int.TryParse(lines[0], out int number))
                {
                    File.WriteAllText("output4.txt", "Ошибка: содержимое файла input4.txt не является целым числом.");
                    return;
                }

                if (number <= 0)
                {
                    File.WriteAllText("output4.txt", "Ошибка: число должно быть положительным.");
                    return;
                }

                int minDigit = MinDigit(number);

                File.WriteAllText("output4.txt", "Минимальная цифра: " + minDigit);
            }
            catch (Exception ex)
            {
                File.WriteAllText("output4.txt", "Ошибка в Z04: " + ex.Message);
            }
        }

        // Функция для нахождения минимальной цифры (вспомогательная для Z04)
        static int MinDigit(int number)
        {
            string numStr = number.ToString();

            int min = 9;

            for (int i = 0; i < numStr.Length; i++)
            {
                int digit = numStr[i] - '0';

                if (digit < min)
                {
                    min = digit;
                }
            }

            return min;
        }

        /// Задание 5: Произведение трех наименьших чисел
        static void Z05()
        {
            try
            {
                string[] lines = File.ReadAllLines("input5.txt");
                if (lines.Length == 0)
                {
                    File.WriteAllText("output5.txt", "Ошибка: файл input5.txt пуст.");
                    return;
                }

                string[] strNumbers = lines[0].Split(' ');
                if (strNumbers.Length < 5)
                {
                    File.WriteAllText("output5.txt", "Ошибка: в файле input5.txt должно быть не менее 5 чисел.");
                    return;
                }

                int[] numbers = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    if (i < strNumbers.Length)
                    {
                        if (!int.TryParse(strNumbers[i], out numbers[i]))
                        {
                            File.WriteAllText("output5.txt", "Ошибка: '" + strNumbers[i] + "' не является целым числом.");
                            return;
                        }
                    }
                    else
                    {
                        File.WriteAllText("output5.txt", "Ошибка: в файле input5.txt должно быть ровно 5 чисел.");
                        return;
                    }
                }
                int result = Min3Of5Mul(numbers[0], numbers[1], numbers[2], numbers[3], numbers[4]);

                File.WriteAllText("output5.txt", "Произведение трех наименьших: " + result);
            }
            catch (Exception ex)
            {
                File.WriteAllText("output5.txt", "Ошибка в Z05: " + ex.Message);
            }
        }

        // Функция для нахождения произведения трех наименьших чисел (вспомогательная для Z05)
        static int Min3Of5Mul(int a, int b, int c, int d, int e)
        {
            int[] nums = { a, b, c, d, e };

            Array.Sort(nums);

            return nums[0] * nums[1] * nums[2];
        }
    }
}