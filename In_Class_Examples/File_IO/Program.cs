
string[] fileContents = File.ReadAllLines("students.csv");

for(int i = 1; i < fileContents.Length; i++)
{
    string line = fileContents[i];
    Console.WriteLine(line);
}
