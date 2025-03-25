using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_13
{
    public class task1
    {
        private int mass;

        public task1()
        {
            mass = 0;
        }

        public void SetMass(int m)
        {
            if (m <= 0)
                throw new ArgumentException("Масса должна быть положительной.");
            mass = m;
        }

        public int GetMass() => mass;

        public int GetTons()
        {
            if (mass == 0)
                throw new InvalidOperationException("Масса не задана.");
            return mass / 1000;
        }

        public int GetTons(int additionalMass)
        {
            if (additionalMass < 0)
                throw new ArgumentException("Дополнительная масса не может быть отрицательной.");
            return (mass + additionalMass) / 1000;
        }

        public static int GetTonsStatic(int m)
        {
            if (m <= 0)
                throw new ArgumentException("Масса должна быть положительной.");
            return m / 1000;
        }
    }
}
