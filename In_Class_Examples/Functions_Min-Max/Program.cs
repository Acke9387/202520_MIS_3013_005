/*
Create a C# console application that generates a list of random numbers and then 
uses functions to determine the smallest and largest values in that list.

When the program starts, it should generate 10 random integers between 
1 and 100 and store them in a List<int>. After generating the numbers, 
the program should display all of them so the user can see the values that were created.

Next, write a function called FindMin that accepts a List<int> as a parameter. 
This function should loop through the list and determine the smallest number, 
then return that value to the main program.

You should also create another function called FindMax that also accepts a 
List<int> as a parameter. This function should loop through the list to determine 
the largest number and return it.

Finally, call both functions using the generated list and display the minimum and 
maximum values to the user.
 */

List<int> values = new List<int>();
values = GenerateRandomList(10);

Console.WriteLine("Values:");
PrintList(values);
//for (int i = 0; i < list.Count; i++)
//{
//    int value = list[i];
//}
//foreach (int value in values)
//{
//    Console.Write(value + "\t");
//}
//Console.WriteLine();


int minValFromValues = FindMin(values);
Console.WriteLine("Minimum Value is :");
Console.WriteLine(minValFromValues);

int maxValFromValues = FindMax(values);
Console.WriteLine("Maximum Value is :");
Console.WriteLine(maxValFromValues);


List<int> list2 = GenerateRandomList(50);
PrintList(list2);

Console.WriteLine();
int minVal2 = FindMin(list2);
Console.WriteLine("Minimum Value is :");
Console.WriteLine(minVal2);

int maxVal2 = FindMax(list2);
Console.WriteLine("Maximum Value is :");
Console.WriteLine(maxVal2);

int FindMax(List<int> list)
{
    int max = list[0];

    foreach (int value in list)
    {
        if (value > max)
        {
            max = value;
        }
    }
    return max;
}

int FindMin(List<int> list)
{
    int min = list[0];

    foreach (int value in list)
    {
        if (value < min)
        {
            min = value;
        }
    }
    return min;
}

List<int> GenerateRandomList(int numberOfItems)
{
    List<int> listOfRandoms = new List<int>();
    for (int i = 0; i < numberOfItems; i++)
    {
        Random r = new Random();
        listOfRandoms.Add(r.Next(1, 101));
    }

    return listOfRandoms;
}

void PrintList(List<int> list)
{
    foreach (int value in list)
    {
        Console.Write(value + "\t");
    }
    Console.WriteLine();
}