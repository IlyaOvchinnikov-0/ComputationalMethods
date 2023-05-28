static float TrapezoidFormula(float a, float b, int m)
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

static float OriginalFunction(float x)
{
    return (float)((0.1 + x * x * Math.Sin(x)) / (x * x - 5));
}

float a = -0.2f, b = 0.4f;
int m = 10;

Console.WriteLine(TrapezoidFormula(a, b, m));