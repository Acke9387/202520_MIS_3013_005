List<double> grades = new List<double>();
List<double> possiblePoints = new List<double>();

int counter = 1;

do
{
    Console.WriteLine($"Please enter the grade you received for assignment {counter++} <<");
    grades.Add(double.Parse(Console.ReadLine()));

    Console.WriteLine("Please enter the total points possible for the assignment <<");
    possiblePoints.Add(double.Parse(Console.ReadLine()));

    Console.WriteLine("Do you have another assignment to enter? yes or no <<");

} while (Console.ReadLine().ToLower() == "yes");

double percent = CalculateOverallPercentage(grades, possiblePoints);

Console.WriteLine("Is this course Pass fail? yes or no <<");
bool passFail;
if (Console.ReadLine().ToLower() == "yes")
{
    passFail = true;
}
else
{
    passFail = false;
}

string finalGrade = DetermineFinalGrade(percent, passFail);


Console.WriteLine($"With a {percent.ToString("P")} in the class, you received a {finalGrade}");

string DetermineFinalGrade(double grade, bool shouldCalculatePassFail)
{
    string finalGrade = "";

    if (shouldCalculatePassFail == true)
    {
        if (grade >= 0.6)
        {
            finalGrade = "Pass";
        }
        else
        {
            finalGrade = "Fail";
        }
    }
    else
    {
        if (grade >= 0.9)
        {
            finalGrade = "A";
        }
        else if (grade >= 0.8)
        {
            finalGrade = "B";
        }
        else if (grade >= 0.7)
        {
            finalGrade = "C";
        }
        else if (grade >= 0.6)
        {
            finalGrade = "D";
        }
        else
        {
            finalGrade = "F";
        }
    }
    return finalGrade;
}



double CalculateOverallPercentage(List<double> pointsEarned, List<double> pointsPossible)
{
    double grade = 0;
    double totalPointsEarned = 0;
    double totalPointsPossible = 0;

    for (int i = 0; i < pointsEarned.Count; i++)
    {
        totalPointsEarned += pointsEarned[i];
        totalPointsPossible += pointsPossible[i];
    }

    grade = (totalPointsEarned / totalPointsPossible) * 100;

    return grade;
}