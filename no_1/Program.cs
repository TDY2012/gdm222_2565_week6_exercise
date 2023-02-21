using System;

class Program
{
    static void Main(string[] args)
    {
        double min = double.Parse(Console.ReadLine());
        double max = double.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Uniform u = new Uniform(min, max);

        while(n > 0)
        {
            Console.WriteLine(u.Generate());
            n--;
        }
    }
}