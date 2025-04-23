using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_14
{
    class task1
    {
        public bool NoReal(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;
            return discriminant < 0;
        }
    }
}
