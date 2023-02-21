public class SaltAndPepper
{
    static Random rnd = new Random();
    private double min;
    private double max;
    private double pMin;
    private double pMax;

    public SaltAndPepper(double min, double max, double pMin, double pMax)
    {
        this.min = min;
        this.max = max;
        this.pMin = pMin;
        this.pMax = pMax;
    }

    public double Generate()
    {
        double prob = rnd.NextDouble();
        if(prob < this.pMin)
        {
            return this.min;
        }
        else if(prob < this.pMin + this.pMax)
        {
            return this.max;
        }
        else
        {
            return 0;
        }
    }
}