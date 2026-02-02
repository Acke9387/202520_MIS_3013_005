//const int HEADS = 0;
//const int TAILS = 1;
const string DEVELOPER_INFO = "Developer: Professor Ackerman";

Console.WriteLine("Welcome to my coin guessing game!");
Random random = new Random();
int tossAsInt = random.Next(0, 2); // 0 or 1

//if (tossAsInt == HEADS)
string toss;
if (tossAsInt == 0)
{
    toss = "Heads";
}
else //if (tossAsInt == 1)
{
    toss = "Tails";
}
Console.WriteLine(toss); // For testing purposes, to see the result of the toss

Console.WriteLine("Do you want to pick 'Heads' or 'Tails'? <<");
string userGuess = Console.ReadLine();

Console.WriteLine($"The coin landed on {toss}");

if (userGuess.ToLower() == toss.ToLower())
{
    Console.WriteLine("You guessed correctly! You win!");
}
else
{
    Console.WriteLine("Sorry, your guess was incorrect. You lose.");
}

Console.WriteLine(DEVELOPER_INFO);