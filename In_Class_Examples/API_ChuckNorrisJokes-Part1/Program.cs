using API_ChuckNorrisJokes_Part1;
using Newtonsoft.Json;

string url = "https://api.chucknorris.io/jokes/random";
ChuckNorrisAPI joke = new ChuckNorrisAPI();

do
{
    using (var client = new HttpClient())
    {
        var response = await client.GetAsync(url);
        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            joke = JsonConvert.DeserializeObject<ChuckNorrisAPI>(json);
            Console.WriteLine(joke);
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
