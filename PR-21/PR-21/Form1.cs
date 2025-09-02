using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Word = Microsoft.Office.Interop.Word;

namespace PR_21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ChisloA_Z1.Text, out int A) ||
                !int.TryParse(ChisloB_Z1.Text, out int B) ||
                !int.TryParse(ChisloC_Z5.Text, out int C))
            {
                lblResult1.Text = "Ошибка ввода!";
                return;
            }

            if (A <= 0 || B <= 0 || C <= 0)
            {
                lblResult1.Text = "Числа должны быть положительными!";
                return;
            }

            bool hasPair = (A == B) || (B == C) || (A == C);
            lblResult1.Text = hasPair ? "Есть совпадающие числа." : "Нет совпадающих чисел.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ChisloN_Z2.Text, out int N) || N <= 0)
            {
                lblResult2.Text = "Ошибка ввода! Введите положительное число.";
                return;
            }

            string numStr = N.ToString();
            if (numStr.Length != 5)
            {
                lblResult2.Text = "Ошибка: число должно быть пятизначным.";
                return;
            }

            int sum = 0;
            int product = 1;
            bool hasEven = false;

            while (N > 0)
            {
                int digit = N % 10;
                sum += digit;
                if (digit % 2 == 0 && digit != 0)
                {
                    product *= digit;
                    hasEven = true;
                }
                N /= 10;
            }

            if (!hasEven) product = 0;

            int difference = sum - product;
            lblResult2.Text = $"Разница: {difference}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ChisloN_Z3.Text, out int bytes) || bytes <= 0)
            {
                lblResult3.Text = "Ошибка ввода! Введите положительное число.";
                return;
            }

            string numStr = bytes.ToString();
            if (numStr.Length != 6)
            {
                lblResult3.Text = "Ошибка: число должно быть шестизначным.";
                return;
            }

            int kilobytes = bytes / 1024;
            int megabytes = kilobytes / 1024;

            lblResult3.Text = $"Файл размером {bytes} байт" +
                              $" | {kilobytes} Кб (полных)" +
                              $" | {megabytes} Мб (полных)";
        }

        private int Max3(int A, int B, int C)
        {
            return Math.Max(A, Math.Max(B, C));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(ChisloA_Z5.Text, out int A) ||
                !int.TryParse(ChisloB_Z5.Text, out int B) ||
                !int.TryParse(ChisloC_Z5.Text, out int C))
            {
                lblResult5.Text = "Ошибка ввода!";
                return;
            }

            int max = Max3(A, B, C);
            lblResult5.Text = $"Максимальное: {max}";
        }

        private void AddHeading(Word.Document doc, string text)
        {
            object missing = System.Reflection.Missing.Value;
            Word.Paragraph para = doc.Content.Paragraphs.Add(ref missing);
            para.Range.Text = text;
            para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            para.Range.Font.Size = 18;
            para.Range.Font.Bold = 1;
            para.Range.InsertParagraphAfter();
            para.CloseUp();
        }

        private void AddText(Word.Document doc, string text)
        {
            object missing = System.Reflection.Missing.Value;
            Word.Paragraph para = doc.Content.Paragraphs.Add(ref missing);
            para.Range.Text = text;
            para.Alignment = Word.WdParagraphAlignment.wdAlignParagraphJustify;
            para.Range.Font.Size = 14;
            para.Range.Font.Bold = 0;
            para.Range.InsertParagraphAfter();
            para.CloseUp();
        }

        private void InsertPageBreak(Word.Document doc)
        {
            object missing = System.Reflection.Missing.Value;
            object pageBreak = Word.WdBreakType.wdPageBreak;
            Word.Paragraph para = doc.Content.Paragraphs.Add(ref missing);
            para.Range.Collapse(Word.WdCollapseDirection.wdCollapseEnd);
            para.Range.InsertBreak(ref pageBreak);
            para.Range.InsertParagraphAfter();
            para.CloseUp();
        }

        private void btnExportToWord_Click(object sender, EventArgs e)
        {
            object missing = System.Reflection.Missing.Value;
            Word.Application wordApp = null;
            Word.Document wordDoc = null;

            try
            {
                wordApp = new Word.Application();
                wordDoc = wordApp.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                wordDoc.PageSetup.Orientation = Word.WdOrientation.wdOrientPortrait;
                wordDoc.PageSetup.TopMargin = wordApp.InchesToPoints(0.60f);
                wordDoc.PageSetup.BottomMargin = wordApp.InchesToPoints(0.60f);
                wordDoc.PageSetup.LeftMargin = wordApp.InchesToPoints(0.80f);
                wordDoc.PageSetup.RightMargin = wordApp.InchesToPoints(0.59f);

                wordApp.Visible = true;

                wordApp.ActiveWindow.Selection.ParagraphFormat.LineSpacingRule = Word.WdLineSpacing.wdLineSpaceSingle;
                wordApp.ActiveWindow.Selection.ParagraphFormat.SpaceAfter = 0f;

                Word.Paragraph title1 = wordDoc.Content.Paragraphs.Add(ref missing);
                title1.Range.Text = "ОТЧЁТ ПО ПРАКТИЧЕСКОЙ РАБОТЕ";
                title1.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                title1.Range.Font.Size = 26;
                title1.Range.Font.Bold = 1;
                title1.Range.InsertParagraphAfter();
                title1.CloseUp();

                Word.Paragraph title2 = wordDoc.Content.Paragraphs.Add(ref missing);
                title2.Range.Text = "по МДК 01.01: Разработка программных модулей";
                title2.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                title2.Range.Font.Size = 18;
                title2.Range.Font.Bold = 1;
                title2.Range.InsertParagraphAfter();
                title2.CloseUp();

                Word.Paragraph title3 = wordDoc.Content.Paragraphs.Add(ref missing);
                title3.Range.Text = "\nВыполнил: ---\nГруппа: ИС-23Б\n";
                title3.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
                title3.Range.Font.Size = 16;
                title3.Range.InsertParagraphAfter();
                title3.CloseUp();

                InsertPageBreak(wordDoc);

                AddHeading(wordDoc, "Задание 1.");
                AddText(wordDoc, "Проверить истинность высказывания: «Среди трех данных целых положительных чисел, введенных с клавиатуры, есть хотя бы одна пара совпадающих».");

                string input1 = $"Введены числа: A = {ChisloA_Z1.Text}, B = {ChisloB_Z1.Text}, C = {ChisloC_Z5.Text}";
                AddText(wordDoc, input1);

                string result1 = lblResult1.Text;
                AddText(wordDoc, $"Результат: {result1}");

                AddHeading(wordDoc, "Задание 2.");
                AddText(wordDoc, "Дано целое положительное пятизначное число N (N > 0). Найти разницу между суммой всех его цифр и произведением четных цифр.");

                string input2 = $"Введено число N: {ChisloN_Z2.Text}";
                AddText(wordDoc, input2);

                string result2 = lblResult2.Text;
                AddText(wordDoc, $"Результат: {result2}");

                AddHeading(wordDoc, "Задание 3.");
                AddText(wordDoc, "Дан размер некоторого файла в байтах (целочисленное положительное ненулевое шестизначное число). Используя операцию деления нацело, найти количество полных килобайтов и мегабайтов, которые занимает данный файл (1 килобайт = 1024 байта, 1 мегабайт = 1024 килобайта).");

                string input3 = $"Размер файла: {ChisloN_Z3.Text} байт";
                AddText(wordDoc, input3);

                string result3 = lblResult3.Text;
                AddText(wordDoc, $"Результат: {result3}");

                AddHeading(wordDoc, "Задание 5.");
                AddText(wordDoc, "Написать функцию int Max3(A, B, C) целого типа, возвращающую одно максимальное значение из 3-х своих аргументов (параметры A, B, C — целые числа).");

                string input5 = $"Введены числа: A = {ChisloA_Z5.Text}, B = {ChisloB_Z5.Text}, C = {ChisloC_Z5.Text}";
                AddText(wordDoc, input5);

                string result5 = lblResult5.Text;
                AddText(wordDoc, $"Результат: {result5}");

                object filename = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
                                  $"\\Отчёт-МДК-CSharp-ПР21.doc";

                wordDoc.SaveAs2(ref filename);
                MessageBox.Show($"Отчёт сохранён:\n{filename}", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при создании Word-документа:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
