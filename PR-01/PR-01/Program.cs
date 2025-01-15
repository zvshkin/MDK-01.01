using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вариант 12\n\n");

            Z05();
            Z12();
            Z25();
        }

        static void Z05()
        {
            Console.WriteLine("Задание 05. Вычисление объема цилиндра");

            Console.WriteLine("Задайте радиус основания (см):");
            int R = Convert.ToInt32(Console.ReadLine()); // Преобразование строки в целое число

            Console.WriteLine("Задайте высоту цилиндра (см):");
            int H = Convert.ToInt32(Console.ReadLine()); 

            double V = Math.PI * Math.Pow(R, 2) * H;
            Console.WriteLine("Объём вашего цилиндра = {0} (см. куб)", V);
        }

        static void Z12()
        {
            Console.WriteLine("\nЗадание 12. Вычисление сопротивления электрической цепи, состоящей из двух последовательно соединенных сопротивлений");

            Console.WriteLine("Величина первого сопротивления (Ом):");
            double A = Convert.ToDouble(Console.ReadLine()); // Преобразование строки в дробное число

            Console.WriteLine("Величина второго сопротивления (Ом):");
            double B = Convert.ToDouble(Console.ReadLine());

            double C = A + B;
            Console.WriteLine("Сопротивление цепи (последовательное соединение) = {0} (Ом)", C);
        }

        static void Z25()
        {
            Console.WriteLine("\nЗадание 25. Пересчет расстояния из миль в километры");
            
            const int Milya = 1605; // Константа для длины одной мили в метрах

            Console.WriteLine("Одна миля = {0} метров", Milya);

            Console.WriteLine("Задайте сколько миль вы хотите первести в километры:");
            int K = Convert.ToInt32(Console.ReadLine());
            
            double Z = Milya * K / 1000.0;
            Console.WriteLine("{0} миль - это {1} километров", K, Z);
        }
    }
}
