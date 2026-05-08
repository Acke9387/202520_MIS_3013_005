using API_ChuckNorrisJokes_Part1;
using Newtonsoft.Json;

ChuckNorrisAPI joke = new ChuckNorrisAPI();
List<string> categories = new List<string>();
List<ChuckNorrisAPI> jokes = new List<ChuckNorrisAPI>();

using (var client = new HttpClient())
{
    var response = await client.GetAsync("https://api.chucknorris.io/jokes/categories");
    if (response.IsSuccessStatusCode)
    {
        string json = await response.Content.ReadAsStringAsync();
        categories = JsonConvert.DeserializeObject<List<string>>(json);
    }
    else
    {
        Console.WriteLine("Failed to retrieve categories.");
        return;
    }
}


do
{
    Console.Clear();
    Console.WriteLine("Available categories:");
    Console.WriteLine($"- all");
    foreach (var c in categories)
    {
        Console.WriteLine($"- {c}");
    }

    Console.WriteLine("Please select a category:");
    string category = Console.ReadLine();

    string url = $"https://api.chucknorris.io/jokes/random";
    if (category.ToLower() != "all")
    {
        url += $"?category={category}";
    }

    using (var client = new HttpClient())
    {
        var response = await client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            joke = JsonConvert.DeserializeObject<ChuckNorrisAPI>(json);
            Console.WriteLine(joke);
            jokes.Add(joke);
        }
        else
        {
            joke = null;
            Console.WriteLine("Failed to retrieve a joke.");
            return;
        }
    }

    Console.WriteLine("Do you want another joke? y/n <<");
} while (Console.ReadLine().ToLower() == "y");

string fileName = "jokes.json";
string fileContents = JsonConvert.SerializeObject(jokes);
File.WriteAllText(fileName, fileContents);
Console.WriteLine($"Saved all jokes to {fileName}.");