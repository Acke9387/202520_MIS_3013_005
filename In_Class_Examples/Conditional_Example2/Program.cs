Random r = new Random();

int randomNumber = r.Next(1, 101);

Console.WriteLine("Please enter a number <<");
string input = Console.ReadLine();
randomNumber = int.Parse(input); // Converts a string to an int
randomNumber = Convert.ToInt32(input); // Another way to convert a string to an int

Console.WriteLine(randomNumber);

if (randomNumber % 3 == 0 && randomNumber % 5 == 0)
{
    Console.WriteLine("Fizzbuzz");
}
else if (randomNumber % 3 == 0)
{
    Console.WriteLine("Fizz");
}
else if (randomNumber % 5 == 0)
{
    Console.WriteLine("Buzz");
}
else
{
    Console.WriteLine(randomNumber);
}
