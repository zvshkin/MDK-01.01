using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_13
{
    public class task5
    {
        private string input;

        public task5()
        {
            input = string.Empty;
        }

        public void SetInput(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException("Строка не может быть пустой.");
            input = str;
        }

        public string GetInput() => input;

        public int CountWordsWithOneH()
        {
            if (string.IsNullOrEmpty(input))
                throw new InvalidOperationException("Строка не задана.");
            string[] words = input.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Count(w => w.Count(c => c == 'h' || c == 'H') == 1);
        }

        public static int CountWordsWithOneHStatic(string str)
        {
            if (string.IsNullOrEmpty(str))
                throw new ArgumentException("Строка не может быть пустой.");
            string[] words = str.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Count(w => w.Count(c => c == 'h' || c == 'H') == 1);
        }
    }
}
