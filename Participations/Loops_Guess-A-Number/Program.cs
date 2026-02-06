do
{
    Console.WriteLine("Welcome to my number guessing game? <<");

    Console.WriteLine("What is the minimum number for the number you want to guess? <<");
    int min = int.Parse(Console.ReadLine());

    Console.WriteLine("What is the maximum number for the number you want to guess? <<");
    int max = int.Parse(Console.ReadLine());

    Random r = new Random();
    int numberToGuess = r.Next(min, max + 1);

    int usersGuess;

    int numberOfGuesses = 0;

    Console.WriteLine(numberToGuess);
    do
    {
        Console.WriteLine("What is your guess? <<");
        usersGuess = int.Parse(Console.ReadLine());
        numberOfGuesses++;
        //numberOfGuesses = numberOfGuesses + 1;

        if (usersGuess < numberToGuess)
        {
            Console.WriteLine("Too low, try again.");
        }
        else if (usersGuess > numberToGuess)
        {
            Console.WriteLine("Too high, try again.");
        }

    } while (usersGuess != numberToGuess);

    Console.WriteLine($"Congratulations you guessed correct in {numberOfGuesses.ToString("N3")}");
    
    Console.WriteLine("Do you want to play again? yes or no <<");
} while (Console.ReadLine().ToLower()[0] == 'y');