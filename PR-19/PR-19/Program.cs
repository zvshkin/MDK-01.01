using System;
using System.Collections.Generic;
using System.Xml;

namespace PR_19
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
            XmlDocument doc = new XmlDocument();
            doc.Load("input1.xml");
            int number = int.Parse(doc.SelectSingleNode("/data/number").InnerText);

            bool result = false;
            if (number > 99 && number < 1000 && number % 2 != 0)
            {
                result = true;
            }

            doc = new XmlDocument();
            XmlElement root = doc.CreateElement("result");
            root.InnerText = result.ToString();
            doc.AppendChild(root);
            doc.Save("output1.xml");

            Console.WriteLine($"Результат записан в output1.xml: {result}");
        }

        // Задание 2: Произведение трех наибольших чисел
        static void Task02()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("input2.xml");
            XmlNodeList nodes = doc.SelectNodes("/data/numbers/number");

            int[] numbers = new int[nodes.Count];
            for (int i = 0; i < nodes.Count; i++)
            {
                numbers[i] = int.Parse(nodes[i].InnerText);
            }

            Array.Sort(numbers);
            Array.Reverse(numbers);

            int product = numbers[0] * numbers[1] * numbers[2];

            doc = new XmlDocument();
            XmlElement root = doc.CreateElement("product");
            root.InnerText = product.ToString();
            doc.AppendChild(root);
            doc.Save("output2.xml");

            Console.WriteLine($"Результат записан в output2.xml: {product}");
        }

        // Задание 3: Вставка нулей после отрицательных элементов
        static void Task03()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("input3.xml");
            XmlNodeList nodes = doc.SelectNodes("/data/numbers/number");

            List<int> numbers = new List<int>();
            foreach (XmlNode node in nodes)
            {
                int num = int.Parse(node.InnerText);
                numbers.Add(num);

                if (num < 0)
                {
                    numbers.Add(0);
                }
            }

            doc = new XmlDocument();
            XmlElement root = doc.CreateElement("result");
            foreach (int num in numbers)
            {
                XmlElement element = doc.CreateElement("number");
                element.InnerText = num.ToString();
                root.AppendChild(element);
            }
            doc.AppendChild(root);
            doc.Save("output3.xml");

            Console.WriteLine("Результат записан в output3.xml.");
        }

        // Задание 4: Минимальное значение из 4 чисел
        static void Task04()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("input4.xml");
            int a = int.Parse(doc.SelectSingleNode("/data/a").InnerText);
            int b = int.Parse(doc.SelectSingleNode("/data/b").InnerText);
            int c = int.Parse(doc.SelectSingleNode("/data/c").InnerText);
            int d = int.Parse(doc.SelectSingleNode("/data/d").InnerText);

            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;
            if (d < min) min = d;

            doc = new XmlDocument();
            XmlElement root = doc.CreateElement("min");
            root.InnerText = min.ToString();
            doc.AppendChild(root);
            doc.Save("output4.xml");

            Console.WriteLine($"Результат записан в output4.xml: {min}");
        }

        // Задание 5: Номер первого символа, нарушающего алфавитный порядок
        static void Task05()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("input5.xml");
            string input = doc.SelectSingleNode("/data/string").InnerText;

            string[] words = input.Split('_');

            int index = 0;
            for (int i = 1; i < words.Length; i++)
            {
                if (string.Compare(words[i - 1], words[i]) > 0)
                {
                    index = i + 1;
                    break;
                }
            }

            doc = new XmlDocument();
            XmlElement root = doc.CreateElement("index");
            root.InnerText = index.ToString();
            doc.AppendChild(root);
            doc.Save("output5.xml");

            Console.WriteLine($"Результат записан в output5.xml: {index}");
        }
    }
}