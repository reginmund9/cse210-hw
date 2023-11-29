public class CryptocurrencyManager
{
    private List<Cryptocurrency> cryptocurrencies;

    public CryptocurrencyManager()
    {
        cryptocurrencies = new List<Cryptocurrency>();
    }

    public void ReadDataFromFile(string filePath)
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines.Skip(1))
            {
                var values = line.Split('-');
                var month = values[0].Trim();
                var name = values[1].Trim();
                var symbol = values[2].Trim();
                var priceUSD = double.Parse(values[3].Replace(",", "."));

                Cryptocurrency crypto = CreateCryptocurrency(month, name, symbol, priceUSD);
                cryptocurrencies.Add(crypto);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading data from file: {ex.Message}");
        }
    }

    private Cryptocurrency CreateCryptocurrency(string month, string name, string symbol, double priceUSD)
    {
        switch (name)
        {
            case "Bitcoin":
                return new Bitcoin(month, priceUSD);
            case "Ethereum":
                return new Ethereum(month, priceUSD);
            case "BinanceCoin":
                return new BinanceCoin(month, priceUSD);

            // ... Add cases for other cryptocurrencies ...
            default:
                throw new ArgumentException($"Unknown cryptocurrency: {name}");
        }
    }

    public void DisplayAllCryptocurrenciesInfo()
    {
        foreach (var crypto in cryptocurrencies)
        {
            crypto.DisplayInfo();
        }
    }

    public void DisplayCryptocurrencyInfoByName(string targetName)
    {
        var filteredCryptos = cryptocurrencies
            .Where(crypto => crypto.GetName().Equals(targetName, StringComparison.OrdinalIgnoreCase));

        if (filteredCryptos.Any())
        {
            Console.WriteLine($"Cryptocurrency information for {targetName}:");
            foreach (var crypto in filteredCryptos)
            {
                crypto.DisplayInfo();
            }
        }
        else
        {
            Console.WriteLine($"No information found for {targetName}.");
        }
    }

    public void DisplayAveragePriceByCurrency()
    {
        var averagePrices = cryptocurrencies
            .GroupBy(crypto => crypto.GetSymbol())
            .Select(group => new
            {
                Symbol = group.Key,
                AveragePrice = group.Average(crypto => crypto.GetPriceUSD())
            });

        Console.WriteLine("Average Price by Currency:");
        foreach (var item in averagePrices)
        {
            Console.WriteLine($"{item.Symbol}: ${item.AveragePrice:F2}");
        }
    }
}

