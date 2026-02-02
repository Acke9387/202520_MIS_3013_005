Console.WriteLine("What is your favorite number? <<");
int favoriteNumber;
string answer = Console.ReadLine();

while (int.TryParse(answer, out favoriteNumber) == false)
{
    Console.WriteLine("Sorry that was not a number.  Please try again <<");
    answer = Console.ReadLine();
}

