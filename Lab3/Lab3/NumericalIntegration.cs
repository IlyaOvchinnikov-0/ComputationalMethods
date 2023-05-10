using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class NumericalIntegration
    {
        
        public static float TrapezoidFormula(float a, float b, int m)
        {
            float h = (b - a) / m;

            float sum = OriginalFunction(a) + OriginalFunction(b);

            for (int i = 1; i <= m - 1; i++)
            {
                sum += 2 * OriginalFunction(a + i * h);
            }

            sum *= h / 2;

            return sum;
        }

        private static float OriginalFunction(float x)
        {
            return (float)((0.1 + x * x * Math.Sin(x)) / (x * x - 5));
        }

        /*public static float GaussQuadratureFormula()
        {

        }*/
    }
}
