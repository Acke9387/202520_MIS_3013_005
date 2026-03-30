using Classes_Toy;

List<Toy> toys = new List<Toy>();

Toy t1 = new Toy();
t1.Manufacturer = "Hasbro";
t1.Name = "Monopoly";
t1.Price = 19.99;
//t1.Notes = "Classic board game";
t1.AddNote("Classic board game");
t1.AddNote("Great for family game night!");

Console.WriteLine(t1);

Toy t2 = new Toy();
t2.Manufacturer = "Lego";
t2.Name= "Star Wars Millennium Falcon";
t2.Price = 159.99; 
t2.AddNote("Detailed model of the Millennium Falcon");

Console.WriteLine(t2);

toys.Add(t1);
toys.Add(t2);




//while (true)
//{
//    Toy t = new Toy();
//    t.Manufacturer = "Nintendo";
//    toys.Add(t);
//}