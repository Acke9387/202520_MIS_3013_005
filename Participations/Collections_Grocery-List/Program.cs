Console.WriteLine("Welcome to the Grocery List App");
Console.WriteLine("Start entering the items for your list and type 'done' when you are finished");

string input;
List<string> groceryList = new List<string>();

do
{
    input = Console.ReadLine();
    if (input.ToLower() != "done")// && groceryList.Contains(input) == false)
    {
        if (groceryList.Contains(input))
        {
            Console.WriteLine($"The item '{input}' is already on the list. Please enter a different item.");
        }
        else
        {
            groceryList.Add(input);

        }
    }

} while (input.ToLower() != "done");

Console.WriteLine($"\nComplete Grocery List:");
Console.WriteLine("".PadLeft(20, '_'));
foreach (string item in groceryList)
{
    Console.WriteLine($"-\t{item}");
}