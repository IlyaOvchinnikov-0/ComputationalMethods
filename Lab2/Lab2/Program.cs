
var N = 23;
var k = 4;
var m = 10;

double[] x = { 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1.0 };
double[] y = { 0.2*N, 0.3*m, 0.5*k, 0.6*N, 0.7*m, k, 0.8*N, 1.2*k, 1.3*m, N};


//Console.WriteLine(Interpolation.LagrangePolynomial(new double[] { 1, 4, 5, 6 }, new double[] { 2, 3, 2, 3 }, 3.0));

//Console.WriteLine(-5 + 9.7333*3 - 3*3*3 + 0.2667*3*3*3);

Console.WriteLine(Interpolation.LagrangePolynomial(x, y, 3.0));

Console.WriteLine();

double[] s = Interpolation.ParabolicSpline(x, y, 3.0);

foreach (double t in s)
{
    Console.WriteLine(t);

}

