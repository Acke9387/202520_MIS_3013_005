
using JSON_Foods;
using Newtonsoft.Json;

string fileContents = File.ReadAllText("foods.json");

FoodAPI api = JsonConvert.DeserializeObject<FoodAPI>(fileContents);

Console.WriteLine("All foods:");

foreach (Food f in api.american_foods)
{
    Console.WriteLine(f);
}
Console.WriteLine();

Console.WriteLine("All foods with a bun:");
foreach (Food f in api.american_foods)
{
	if (f.ingredients.Contains("bun"))
	{
		Console.WriteLine(f); 
	}
}