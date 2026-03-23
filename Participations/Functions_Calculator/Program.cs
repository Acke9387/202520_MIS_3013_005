DeveloperInformation("Professor Ackerman", "MIS 3013 - Introduction to programming", DateTime.Now.ToString());



// get user inputs ...
//...
//


if (operation == "+")
{
    double result = Add(leftOperand, rightOperand);
    Console.WriteLine($"Result: {result}");
}




double Add(double leftOperand, double rightOperand)
{
    return leftOperand + rightOperand;
}

void DeveloperInformation(string name, string course, string date)
{
    Console.WriteLine($"Developer Name: {name}");
    Console.WriteLine($"Course: {course}");
    Console.WriteLine($"Date: {date}");
}