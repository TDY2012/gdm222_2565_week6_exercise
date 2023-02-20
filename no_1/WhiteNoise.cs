public class WhiteNoise
{
    static Random rnd = new Random();
    private double min;
    private double max;

    public WhiteNoise(double min, double max)
    {
        this.min = min;
        this.max = max;
    }

    public double Generate()
    {
        return rnd.NextDouble()*(max - min) + min;
    }
}