class Interpolation
{
    public static double LagrangePolynomial(double[] xA, double[] yA, double x)
    {
        double s = 0.0;

        for (int i = 0; i < xA.Length; i++)
        {
            s += yA[i] * l(x, i, xA);
        }

        return s;
    }

    private static double l(double x, int i, double[] xA)
    {
        double numerator = 1.0, denominator = 1.0;
        for (int j = 0; j < xA.Length; j++)
        {
            if (j == i) continue;
            numerator *= x - xA[j];
            denominator *= xA[i] - xA[j];
        }
        return numerator / denominator;
    }

    public static double[] ParabolicSpline(double[] xA, double[] yA, double x)
    {
        double[] s = new double[xA.Length - 1];

        for (int i = 0; i < s.Length - 1; i++)
        {
            s[i] = a(xA, yA, i) * (x - xA[i]) * (x - xA[i]) + b(xA, yA, i) * (x - xA[i]) + yA[i];
        }

        return s;
    }
    private static double h(double[] xA, int i)
    {
        return xA[i+1] - xA[i];
    }
    private static double b(double[] xA, double[] yA, int i)
    {
        if (i == 0) return 0.0;
        return ((2 * (yA[i] - yA[i - 1])) / h(xA, i)) - b(xA, yA, i - 1);
    }

    private static double a(double[] xA, double[] yA, int i)
    {
        return (b(xA, yA, i + 1) - b(xA, yA, i)) / (2 * h(xA, i));
    }
}
