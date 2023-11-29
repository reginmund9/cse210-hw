public class Bitcoin : Cryptocurrency
{
    public Bitcoin(string month, double priceUSD) : base(month, "Bitcoin", "BCT", priceUSD) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{month} - {name} ({symbol}): ${priceUSD:F2}");
    }
}