class Histogram
{
    private double min;
    private double binSize;
    private int binCount;
    private int[] frequency;

    public Histogram(double min, double max, int binCount)
    {
        this.min = min;
        this.binCount = binCount;
        this.binSize = (max - min)/binCount;
        this.frequency = new int[binCount];
    }

    public void Add(double value)
    {
        if(value < this.min)
            return;

        int binIndex = (int)((value - this.min)/this.binSize);
        this.frequency[binIndex]++;
    }

    public override string ToString()
    {
        string message = "";
        for(int i=0; i<this.binCount; i++)
        {
            message += string.Format("{0}\n", this.frequency[i]);
        }

        return message;
    }
}