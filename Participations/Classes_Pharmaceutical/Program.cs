using Classes_Pharmaceutical;

List<Drug> drugList = new List<Drug>();
string[] linesOfFile = File.ReadAllLines("Pharmaceutical Drugs.csv");

for (int i = 1; i < linesOfFile.Length; i++)
{
    Drug drug = new Drug();
    // 0     1      2     3      4
    //Name,Company,Brand,Code,StreetName
    string[] parts = linesOfFile[i].Split(',');
    drug.Name = parts[0];
    drug.Company = parts[1];
    drug.Brand = parts[2];
    drug.Code = int.Parse(parts[3]);
    drug.StreetName = parts[4];

    drugList.Add(drug);
}

DisplayAllDrugs(drugList);
Console.WriteLine("Which drug would you like to see all that match?");
string input = Console.ReadLine();
Console.Clear();

foreach (var d in drugList)
{
    if (d.Name == input)
    {
        Console.WriteLine(d);
    }
}

void DisplayAllDrugs(List<Drug> drugList)
{
    List<string> names = new List<string>();

    foreach (var d in drugList)
    {
        if (names.Contains(d.Name) == false)
        {
            Console.WriteLine(d.Name);
            names.Add(d.Name);
        }
    }
}