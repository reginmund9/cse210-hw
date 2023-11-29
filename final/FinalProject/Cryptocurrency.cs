public abstract class Cryptocurrency
{
    protected string month;
    protected string name;
    protected string symbol;
    protected double priceUSD;

    public Cryptocurrency(string month, string name, string symbol, double priceUSD)
    {
        this.month = month;
        this.name = name;
        this.symbol = symbol;
        this.priceUSD = priceUSD;
    }

    public abstract void DisplayInfo();
}