const int EXAM_COUNT = 3;
double exam1;
double exam2;
double exam3;

double[] exams = new double[EXAM_COUNT];
int[] ids = new int[EXAM_COUNT];

//Console.WriteLine("What is your score for exam 1? <<");
//exam1 = double.Parse(Console.ReadLine());
//Console.WriteLine("What is your score for exam 2? <<");
//exam2 = double.Parse(Console.ReadLine());
//Console.WriteLine("What is your score for exam 3? <<");
//exam3 = double.Parse(Console.ReadLine());

for (int i = 0; i < exams.Length; i++)
{
    Console.WriteLine($"What is your score for exam {i + 1}? <<");
    exams[i] = double.Parse(Console.ReadLine());

    Console.WriteLine($"What is the student's id who scored {exams[i]}? <<");
    ids[i] = int.Parse(Console.ReadLine());
}

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

average = sum / exams.Length;

Console.WriteLine($"The average of your {exams.Length} exams is {(average / 100).ToString("P")}");

Console.WriteLine("Do you want to see everyones exam scores? yes or no <<");

if (Console.ReadLine().ToLower() == "yes")
{
    Console.WriteLine("Student:\t\tExam Score:");
    for (int i = 0; i < exams.Length; i++)
    {
        Console.WriteLine($"{ids[i]}\t\t\t{exams[i]}"); 
    }

}