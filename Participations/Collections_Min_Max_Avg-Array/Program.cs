Console.WriteLine("How many exam grades do you have? <<");
int numberOfExamsGrades = int.Parse(Console.ReadLine());

// Create an array to hold the exam grades
double[] examGrades = new double[numberOfExamsGrades];

for (int i = 0; i < numberOfExamsGrades; i++)
{
    Console.WriteLine($"What was your score for exam {i + 1}? <<");
    examGrades[i] = double.Parse(Console.ReadLine());
}

double minGrade = examGrades[0];
double maxGrade = examGrades[0];
double sum = 0;

foreach (double grade in examGrades)
{
    if (grade < minGrade)
    {
        minGrade = grade;
    }

    if (grade > maxGrade)
    {
        maxGrade = grade;
    }

    sum += grade;

}

double averageGrade = sum / numberOfExamsGrades;
averageGrade = averageGrade / 100;
Console.WriteLine($"The minimum grade for the exams was {minGrade:N2}");
Console.WriteLine($"The maximum grade for the exams was {maxGrade.ToString("N2")}");
Console.WriteLine($"The average grade for the exams was {averageGrade.ToString("P2")}");
