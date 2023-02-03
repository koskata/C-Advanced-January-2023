double[] prices = Console.ReadLine()
                .Split(", ")
                .Select(Parse)
                .ToArray();

for (int i = 0; i < prices.Length; i++)
{
    prices[i] += prices[i] * 0.20;
}

//Console.WriteLine($"{String.Join(Environment.NewLine, prices)}");
foreach (var item in prices)
{
    Console.WriteLine($"{item:f2}");
}


double Parse(string x)
{
    return double.Parse(x);
}
