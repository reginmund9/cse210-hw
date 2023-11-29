public class Dogecoin : Cryptocurrency
{
    public Dogecoin(string month, double priceUSD) : base(month, "BinanceCoin", "BNB", priceUSD) { }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{month} - {name} ({symbol}): ${priceUSD:F2}");
    }
}