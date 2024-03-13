// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("modyfikacja 1");
Console.WriteLine("modyfikacja 2");
Console.WriteLine("modyfikacja 3");

static double GetAverage(int[] x)
{
    double suma = 0;
    for (int i = 0; i < x.Length; i++)
    {
        suma += x[i];
    }

    return suma / x.Length;
}

int[] x = new []{1,2,3,4};

Console.WriteLine(GetAverage(x));

static int GetMax(int[] x)
{
    return x.Max();
}

Console.WriteLine(GetMax(x));