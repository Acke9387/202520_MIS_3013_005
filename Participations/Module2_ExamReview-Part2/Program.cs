using Module2_ExamReview_Part2;

List<Major> majors = new List<Major>();

do
{
    Major m = new Major();
    //MajorName = string.Empty;
    //AverageSalary = 0;
    //RequriedGPA = 0;
    //GraduationRate = 0;
    //AverageStudentDebt = 0;
    //NumberOfStudents = 0;
    //RequiredCourses = 0;

    Console.WriteLine("What is the majors name? <<");
    string name = Console.ReadLine();
    m.MajorName = name;
    //m.MajorName = Console.ReadLine();
    Console.WriteLine("What is the average salary? <<");
    m.AverageSalary = double.Parse(Console.ReadLine());
    Console.WriteLine("What is the required GPA? <<");
    m.RequriedGPA = double.Parse(Console.ReadLine());
    Console.WriteLine("What is the graduation rate?<<");
    m.GraduationRate = double.Parse(Console.ReadLine());
    Console.WriteLine("What is the average student debt?");
    m.AverageStudentDebt = double.Parse(Console.ReadLine());
    Console.WriteLine("WHat is the number of students?");
    m.NumberOfStudents = int.Parse(Console.ReadLine());
    Console.WriteLine("How many required courses are there? <<");
    m.RequiredCourses = int.Parse(Console.ReadLine());

    majors.Add(m);

    Console.WriteLine("Do you have another major to enter? yes or no <<");
} while (Console.ReadLine().ToLower() == "yes");

Console.WriteLine("What is the minimum salary of a Major that you want to see in your results?<<");
double minSalary = double.Parse(Console.ReadLine());

foreach (Major m in majors)
{
    if (m.AverageSalary >= minSalary)
    {
        Console.WriteLine(m);
    }
}