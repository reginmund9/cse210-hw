public class Ethereum : Cryptocurrency
{
    public Ethereum(string month, double priceUSD) : base(month, "Ethereum", "ETH", priceUSD) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{month} - {name} ({symbol}): ${priceUSD:F2}");
    }
}