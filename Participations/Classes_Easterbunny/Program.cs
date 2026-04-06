using Classes_Easterbunny;

List<Bunny> bunnies = new List<Bunny>();

//Bunny bunny = new Bunny();
//bunny.Name = "Binky";
//bunny.Location = "South Oval";
//bunny.EggCount = 100;
//bunny.Age = 12;
//bunny.BasketSize = 12;
//bunny.DeliveryDate = new DateTime(2024,3,31);
//bunny.EggColor = "Pink";
//bunny.FavoriteColor = "Blue";

//bunnies.Add(bunny);

//"Binky,SouthOval,100,12,March 31 2024,Pink,Blue"


//foreach (Bunny b in bunnies)
//{
//    Console.WriteLine(b);
//    Console.WriteLine($" and needs {b.HowManyEasterBaskets()} baskets to deliver all his eggs") ;
//}


// 0    1        2         3        4         5         6           7
//Name,Age,FavoriteColor,Location,EggCount,EggColor,BasketSize,DeliveryDate

//string line = "Name,Age,FavoriteColor,Location,EggCount,EggColor,BasketSize,DeliveryDate";

string[] lines = File.ReadAllLines("Easter_Bunny.csv");


for (int i = 1; i < lines.Length; i++)
{
    string line = lines[i];
    string[] partsOfFile = line.Split(',');
    // partsOfFile[0]"Name"
    // partsOfFile[1]"Age"
    // partsOfFile[2]"FavoriteColor"
    // partsOfFile[3]"Location"
    // partsOfFile[4]"EggCount"
    // partsOfFile[5]"EggColor"
    // partsOfFile[6]"BasketSize""
    // partsOfFile[7]"DeliveryDate"
    Bunny b = new Bunny();
    b.Name = partsOfFile[0];
    b.Age = int.Parse(partsOfFile[1]);
    b.FavoriteColor = partsOfFile[2];
    b.Location = partsOfFile[3];
    b.EggCount = int.Parse(partsOfFile[4]);
    b.EggColor = partsOfFile[5];
    b.BasketSize = int.Parse(partsOfFile[6]);
    b.DeliveryDate = DateTime.Parse(partsOfFile[7]);

    bunnies.Add(b);
}

int totalEggs = 0;

foreach (Bunny temp in bunnies)
{
    totalEggs += temp.EggCount;
}


Console.WriteLine($"Total number of eggs for delivery are {totalEggs.ToString("N0")}");

Console.WriteLine("All easter bunnies whose age is > 75:");
foreach (Bunny temp in bunnies)
{
    if (temp.Age > 75)
    {
        Console.WriteLine("\t" + temp);
    }
}

Console.WriteLine();
Console.WriteLine("All easter bunnies whose age is < 20");
foreach (Bunny temp in bunnies)
{
    if (temp.Age < 20)
    {
        Console.WriteLine("\t" + temp);
    }
}