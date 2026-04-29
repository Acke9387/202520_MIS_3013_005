
using JSON_API;
using Newtonsoft.Json;

RickAndMortyAPI api = new RickAndMortyAPI();

string url = "https://rickandmortyapi.com/api/character";

using (var client = new HttpClient())
{
    var response = await client.GetAsync(url);

    if (response.IsSuccessStatusCode == true)
    {
        string json = await response.Content.ReadAsStringAsync();
        api = JsonConvert.DeserializeObject<RickAndMortyAPI>(json);
    }
    else
    {
        Console.WriteLine("Error");
        return;
    }
}

foreach (var item in api.results)
{
    Console.WriteLine(item);
}