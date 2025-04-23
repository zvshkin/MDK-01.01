using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_14
{
    class task3
    {
        public int Max4(int a, int b, int c, int d)
        {
            return Math.Max(Math.Max(a, b), Math.Max(c, d));
        }
        public int Max4(int a, int b, int c)
        {
            return Math.Max(Math.Max(a, b), c);
        }
        public int Max4(int a, int b)
        {
            return Math.Max(a, b);
        }
        public int Max4(int a)
        {
            return a;
        }
    }
}
