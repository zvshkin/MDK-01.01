using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_13
{
    public class task3
    {
        private double baseLength;
        private double height;

        public task3()
        {
            baseLength = 0;
            height = 0;
        }

        public void SetDimensions(double a, double h)
        {
            if (a <= 0 || h <= 0)
                throw new ArgumentException("Основание и высота должны быть положительными.");
            baseLength = a;
            height = h;
        }

        public double GetBase() => baseLength;
        public double GetHeight() => height;

        public double TriangleP()
        {
            if (baseLength == 0 || height == 0)
                throw new InvalidOperationException("Основание или высота не заданы.");
            double b = Math.Sqrt(Math.Pow(baseLength / 2, 2) + Math.Pow(height, 2));
            return baseLength + 2 * b;
        }

        public double TriangleP(double a)
        {
            if (a <= 0)
                throw new ArgumentException("Основание должно быть положительным.");
            double b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(height, 2));
            return a + 2 * b;
        }

        public double TriangleP(double a, double h)
        {
            if (a <= 0 || h <= 0)
                throw new ArgumentException("Основание и высота должны быть положительными.");
            double b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));
            return a + 2 * b;
        }

        // Статический метод
        public static double TrianglePStatic(double a, double h)
        {
            if (a <= 0 || h <= 0)
                throw new ArgumentException("Основание и высота должны быть положительными.");
            double b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));
            return a + 2 * b;
        }
    }
}
