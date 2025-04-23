using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_14
{
    class task2
    {
        public int Delenie(int n)
        {
            int product = 1;
            while (n > 0)
            {
                product *= n % 10;
                n /= 10;
            }
            return product;
        }
    }
}
