using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_16
{
    internal class Task01
    {
        public static double ConvertFahrenheitToCelsius(int Tf)
        {
            if (Tf == 0)
                throw new ArgumentException("Температура не может быть равна 0.");
            return (Tf - 32) * 5.0 / 9;
        }
    }
}
