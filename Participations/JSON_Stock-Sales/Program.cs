using JSON_Stock_Sales;
using Newtonsoft.Json;

List<StockOption> stocks = new List<StockOption>();
string fileContents = File.ReadAllText("stock_sales.json");

stocks = JsonConvert.DeserializeObject<List<StockOption>>(fileContents);


Console.WriteLine("1.Display information for all stock transactions.\r\n2.Display only transactions for a specific stock symbol.\r\n3.Display only transactions where the investor made a profit.");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1: //All
        foreach (StockOption stock in stocks)
        {
            Console.WriteLine(stock);
        }
        break;
    case 2://Specific stock symbol
        Console.WriteLine("Enter the stock symbol:");
        string symbol = Console.ReadLine();
        foreach (StockOption stock in stocks)
        {
            if (stock.StockSymbol == symbol)
            {
                Console.WriteLine(stock);
            }
        }
        break;
    case 3: // Profit
        foreach (StockOption stock in stocks)
        {
            if (stock.IsProfit())
            {
                Console.WriteLine(stock);
            }
        }
        break;
    default:
        Console.WriteLine("Invalid choice.");
        break;
}

if (choice == 1)
{

}
else if (choice == 2)
{

}
else if (choice == 3)
{

}