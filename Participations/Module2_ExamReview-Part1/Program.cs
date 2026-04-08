do
{
    Console.WriteLine("What is the value in feet that you want to convert to meters? <<");
    double feet = Convert.ToDouble(Console.ReadLine());
    double m = FeetToMeters(feet);

    Console.WriteLine($"{feet.ToString("N")} converted to meters is {m.ToString("N")}");

    Console.WriteLine("Do you want to convert another number? yes or no <<");
} while (Console.ReadLine().ToLower() == "yes");

//ReturnType FunctionName(ParameterList)
double FeetToMeters(double ft)
{
    double meters = 0;

    meters = ft * 0.3048;

    return meters;
}