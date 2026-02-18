
List<double> exams = new List<double>();
List<int> ids = new List<int>();
int i = 0;
do
{
    Console.WriteLine($"What is your score for exam {i + 1}? <<");
    exams.Add(double.Parse(Console.ReadLine()));

    Console.WriteLine($"What is the student's id who scored {exams[i]}? <<");
    ids.Add(int.Parse(Console.ReadLine()));
    i++;
    Console.WriteLine("Do you have another students score to add? yes or no <<");
} while (Console.ReadLine() == "yes");


double sum = 0, average = 0;

//for (int i = 0; i < exams.Length; i++)
//{
//    double grade = exams[i];
//    sum += grade;

//}
foreach (double grade in exams)
{
    sum = sum + grade;
}

average = sum / exams.Count;

Console.WriteLine($"The average of your {exams.Count} exams is {(average / 100).ToString("P")}");

Console.WriteLine("Do you want to see everyones exam scores? yes or no <<");

if (Console.ReadLine().ToLower() == "yes")
{
    Console.WriteLine("Student:\t\tExam Score:");
    for (int x = 0; x < exams.Count; x++)
    {
        Console.WriteLine($"{ids[x]}\t\t\t{exams[x]}");
    }

}