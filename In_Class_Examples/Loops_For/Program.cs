Console.WriteLine("Welcome to the Fizz Buzz Application");
Console.WriteLine("What number do you want to calculate up to? <<");
int upperBound = int.Parse(Console.ReadLine());


for (int i = 1; i <= upperBound; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine("Fizzbuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Buzz");
    }
    else
    {
        Console.WriteLine(i);
    }

}