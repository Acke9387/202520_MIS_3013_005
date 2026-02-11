const double PRICE_PER_BURRITO = 9.00;
const double FIXED_COSTS = 1200.00;
const double VARIABLE_COST_PER_BURRITO = 3.80;

int burritosSold = 0;
double revenue = 0.00;
double totalCost = 0.00;
double profitOrLoss = 0.00;

while (revenue <= totalCost)
{
    burritosSold++;
    //burritosSold = burritosSold + 1;
    revenue = PRICE_PER_BURRITO * burritosSold;
    totalCost = FIXED_COSTS + (VARIABLE_COST_PER_BURRITO * burritosSold);
    profitOrLoss = revenue - totalCost;

    if (profitOrLoss < 0)
    {
        Console.WriteLine($"After selling {burritosSold} burritos --> still losing money {profitOrLoss.ToString("C2")}");
    }
    else
    {
        Console.WriteLine($"After selling {burritosSold.ToString("N2")} burritos --> PROFIT! +{profitOrLoss.ToString("N2")}");
        Console.WriteLine($"Break-even point is between {(burritosSold - 1).ToString("N2")} and {burritosSold.ToString("N2")} burritos.");
        Console.WriteLine($"Minimum to make profit: {burritosSold.ToString("N2")} burritos");

    }

}





