Console.WriteLine("How many bank account's do you have? <<");
string input = Console.ReadLine();

int numberOfAccounts;
while (!int.TryParse(input, out numberOfAccounts))
{
    Console.WriteLine("Please enter a valid number of accounts. <<");
    input = Console.ReadLine();
}

double totalBalance = 0;

for (int i = 0; i < numberOfAccounts; i++)
{
    Console.WriteLine($"What is the balance of your {i+1} account? <<");
    //double balance = double.Parse(Console.ReadLine());
    input = Console.ReadLine();
    double balance;

    while (!double.TryParse(input, out balance))
    {
        Console.WriteLine("Please enter a valid balance. <<");
        input = Console.ReadLine();
    }

    //totalBalance += balance;
    totalBalance = totalBalance + balance;

}

Console.WriteLine($"The total balance across all of your accounts is {totalBalance.ToString("C2")}");
double averageBalance = totalBalance / numberOfAccounts;

Console.WriteLine($"The average balance across all of your accounts is {averageBalance.ToString("C2")}");