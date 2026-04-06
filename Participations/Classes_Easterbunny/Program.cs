using Classes_Easterbunny;

List<Bunny> bunnies = new List<Bunny>();

Bunny bunny = new Bunny();
bunny.Name = "Binky";
bunny.Location = "South Oval";
bunny.EggCount = 100;
bunny.Age = 12;
bunny.BasketSize = 12;
bunny.DeliveryDate = new DateTime(2024,3,31);
bunny.EggColor = "Pink";
bunny.FavoriteColor = "Blue";

bunnies.Add(bunny);

//"Binky,SouthOval,100,12,March 31 2024,Pink,Blue"


foreach (Bunny b in bunnies)
{
    Console.WriteLine(b);
    Console.WriteLine($" and needs {b.HowManyEasterBaskets()} baskets to deliver all his eggs") ;
}