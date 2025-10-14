using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR_25
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Task1ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Task1NumberInput.Text, out int number))
            {
                if (number >= 100 && number <= 999 && number % 2 != 0)
                {
                    Task1ResultOutput.Text = "Истина";
                }
                else
                {
                    Task1ResultOutput.Text = "Ложь";
                }
            }
            else
            {
                MessageBox.Show("Ошибка ввода! Пожалуйста, введите целое положительное число.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Task1ResultOutput.Text = "";
            }
        }

        private void Task2ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var textBoxes = new[] { Task2Num1, Task2Num2, Task2Num3, Task2Num4, Task2Num5 };
                var numbers = new List<int>();

                foreach (var tb in textBoxes)
                {
                    if (!int.TryParse(tb.Text, out int num) || num == 0)
                    {
                        throw new FormatException("Все поля должны содержать ненулевые целые числа.");
                    }
                    numbers.Add(num);
                }

                if (numbers.Distinct().Count() != numbers.Count)
                {
                    throw new InvalidOperationException("Числа не должны повторяться.");
                }

                numbers.Sort((a, b) => b.CompareTo(a));

                long product = (long)numbers[0] * numbers[1] * numbers[2];

                Task2ResultOutput.Text = product.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Task2ResultOutput.Text = "";
            }
        }


        private int Min4(int a, int b, int c, int d)
        {
            return Math.Min(a, Math.Min(b, Math.Min(c, d)));
        }

        private void Task4ExecuteButton_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(Task4NumA.Text, out int a) &&
                int.TryParse(Task4NumB.Text, out int b) &&
                int.TryParse(Task4NumC.Text, out int c) &&
                int.TryParse(Task4NumD.Text, out int d))
            {
                int min = Min4(a, b, c, d);
                Task4ResultOutput.Text = min.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка ввода! Все четыре поля должны содержать целые числа.");
                Task4ResultOutput.Text = "";
            }
        }
    }
}
