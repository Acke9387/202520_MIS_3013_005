using System.Security.Principal;

Console.WriteLine("Welcome to the product tracker.");

//          KEY     VALUE
Dictionary<string, double> productCatalog = new Dictionary<string, double>();
string input = "";
do
{
    Console.WriteLine("What product would you like to keep track of? <<");
    string productName = Console.ReadLine();

    if (productName != "done")
    {
        Console.WriteLine($"What is the price for {productName}? <<");
        double productPrice = Convert.ToDouble(Console.ReadLine());
        if (productCatalog.ContainsKey(productName) == false)
        {
            productCatalog.Add(productName, productPrice); 
        }
        else
        {
            productCatalog[productName] = productPrice;
            Console.WriteLine($"{productName} was already in the catalog so we updated the price.");
        }
    }
    else
    {
        input = productName;
    }


} while (input.ToLower() != "done");

do
{
    foreach (string productName in productCatalog.Keys)
    {
        Console.WriteLine($"{productName} - {productCatalog[productName].ToString("C")}");
    }

    Console.WriteLine("Do you want to edit any of the values? (yes/no) <<");
    input = Console.ReadLine();

    if (input.ToLower() == "yes")
    {
        Console.WriteLine("What product would you like to update? <<");
        string productName = Console.ReadLine();

        Console.WriteLine($"What is the new price of {productName}? <<");
        double newPrice = Convert.ToDouble(Console.ReadLine());

        if (productCatalog.ContainsKey(productName))
        {
            productCatalog[productName] = newPrice;
            Console.WriteLine($"{productName} was updated to {newPrice.ToString("C")}");
        }
        else
        {
            Console.WriteLine($"{productName} is not in the catalog.");
        }
    } 
} while (input.ToLower() != "yes");