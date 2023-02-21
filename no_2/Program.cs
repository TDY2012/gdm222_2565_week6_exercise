using System;

class Program
{
    static void Main(string[] args)
    {
        double min = double.Parse(Console.ReadLine());
        double max = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int binCount = int.Parse(Console.ReadLine());
        Uniform u = new Uniform(min, max);
        Histogram h = new Histogram(min, max, binCount);

        double value;
        while(n > 0)
        {
            value = u.Generate();
            h.Add(value);
            Console.WriteLine(value);
            n--;
        }

        Console.WriteLine(h);
    }
}