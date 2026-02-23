Dictionary<int, double> studentGrades = new Dictionary<int, double>();

int i = 0;
do
{
    Console.WriteLine($"What is your score for exam {i + 1}? <<");
    double examGrade = (double.Parse(Console.ReadLine()));

    Console.WriteLine($"What is the student's id who scored {examGrade}? <<");
    int id = (int.Parse(Console.ReadLine()));

    if (studentGrades.ContainsKey(id) == false)
    {
        studentGrades.Add(id, examGrade);
    }
    else
    {
        Console.WriteLine("");
        studentGrades[id] = examGrade;
    }

    i++;
    Console.WriteLine("Do you have another students score to add? yes or no <<");
} while (Console.ReadLine() == "yes");


double sum = 0, average = 0;

foreach (int studentID in studentGrades.Keys)
{
    sum = sum + studentGrades[studentID];
}

average = sum / studentGrades.Count;

Console.WriteLine($"The average of your {studentGrades.Count} exams is {(average / 100).ToString("P")}");

Console.WriteLine("Do you want to see everyones exam scores? yes or no <<");

if (Console.ReadLine().ToLower() == "yes")
{
    Console.WriteLine("Student:\t\tExam Score:");
    foreach (int studentID in studentGrades.Keys)
    {
        Console.WriteLine($"{studentID}\t\t\t{studentGrades[studentID]}");
    }
}

Console.WriteLine("What student do you want to look up, please enter their id <<");
int idToLookUp = int.Parse(Console.ReadLine());

Console.WriteLine($"Student {idToLookUp} has a grade of {studentGrades[idToLookUp]}");