
using File_IO;

string[] fileContents = File.ReadAllLines("students.csv");
List<Student> students = new List<Student>();

for (int i = 1; i < fileContents.Length; i++)
{
    string line = fileContents[i];

    //           0        1      2         3   4
    //line = full_name,gender,birthdate,email,city

    string[] partsOfLine = line.Split(',');
    Student s = new Student();
    s.full_name = partsOfLine[0];
    s.gender = partsOfLine[1];
    s.birthdate = DateTime.Parse(partsOfLine[2]);
    s.email = partsOfLine[3];
    s.city = partsOfLine[4];

    students.Add(s);
}

List<Student> whiteHouseEmployees = new List<Student>();

string newFileContents = "full_name,gender,birthdate,email,city";
foreach (Student student in students)
{
    if (student.email.Contains("whitehouse.gov"))
    {
        whiteHouseEmployees.Add(student);
        Console.WriteLine(student);
        newFileContents += Environment.NewLine + student.ToCSV();
    }
}

File.WriteAllText("whitehouse_employees.csv", newFileContents);
Console.WriteLine("Successfully wrote whitehouse_employees.csv");
