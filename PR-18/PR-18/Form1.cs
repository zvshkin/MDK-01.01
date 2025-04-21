using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCheckPositive_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text, out int a) ||
                !int.TryParse(txtB.Text, out int b) ||
                !int.TryParse(txtC.Text, out int c))
            {
                lblResultPositive.Text = "Ошибка ввода!";
                return;
            }

            bool allPositive = a > 0 && b > 0 && c > 0;

            if (allPositive)
            {
                lblResultPositive.Text = "Высказывание истинно.";
            }
            else
            {
                lblResultPositive.Text = "Высказывание ложно.";
            }
        }

        private void btnCalculateDifference_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNumber.Text, out int n) || n <= 0 || n.ToString().Length != 5)
            {
                lblResultDifference.Text = "Ошибка ввода! Введите пятизначное число.";
                return;
            }

            int sum = 0;
            int product = 1;
            bool hasEven = false;

            while (n > 0)
            {
                int digit = n % 10;
                sum += digit;

                if (digit % 2 == 0)
                {
                    product *= digit;
                    hasEven = true;
                }

                n /= 10;
            }

            if (!hasEven)
            {
                product = 0; // Если нет четных цифр, произведение равно 0
            }

            int difference = sum - product;
            lblResultDifference.Text = $"Разница: {difference}";
        }

        private int SumRange(int start, int end)
        {
            if (start > end)
            {
                return 0;
            }

            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            return sum;
        }

        private void btnCalculateSumRange_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtStart.Text, out int start) || start <= 0 ||
                !int.TryParse(txtEnd.Text, out int end) || end <= 0)
            {
                lblResultSumRange.Text = "Ошибка ввода!";
                return;
            }

            int result = SumRange(start, end);
            lblResultSumRange.Text = $"Сумма: {result}";
        }

        private void btnReverseSubarray_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtArraySize.Text, out int size) || size <= 0)
            {
                lblResultReverse.Text = "Ошибка ввода размера массива!";
                return;
            }

            string[] input = txtArrayElements.Text.Split(' ');
            if (input.Length != size)
            {
                lblResultReverse.Text = "Количество элементов не соответствует размеру массива!";
                return;
            }

            int[] array = Array.ConvertAll(input, s => int.Parse(s));
            int minIndex = Array.IndexOf(array, array.Min());
            int maxIndex = Array.IndexOf(array, array.Max());

            if (minIndex > maxIndex)
            {
                int temp = minIndex;
                minIndex = maxIndex;
                maxIndex = temp;
            }

            Array.Reverse(array, minIndex, maxIndex - minIndex + 1);
            lblResultReverse.Text = $"Результат: {string.Join(", ", array)}";
        }
    }
}
