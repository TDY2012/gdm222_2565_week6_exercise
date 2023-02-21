using System;

class Program
{
    static void Main(string[] args)
    {
        double min = double.Parse(Console.ReadLine());
        double max = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        double pMin = double.Parse(Console.ReadLine());
        double pMax = double.Parse(Console.ReadLine());
        int binCount = int.Parse(Console.ReadLine());
        SaltAndPepper s = new SaltAndPepper(min, max, pMin, pMax);
        Histogram h = new Histogram(min, max + (max - min)/binCount, binCount + 1);

        double value;
        while(n > 0)
        {
            value = s.Generate();
            h.Add(value);
            Console.WriteLine(value);
            n--;
        }

        Console.WriteLine(h);
    }
}