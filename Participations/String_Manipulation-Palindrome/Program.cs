Console.WriteLine("Please input a word to see if it is a palindrome. <<");
string word = Console.ReadLine();

//       012
//word = car
string reverse = "";
for (int i = word.Length - 1; i >= 0; i--)
{
    reverse = reverse + word[i];
}

if (reverse == word)
{
    Console.WriteLine("The word is a palindrome.");
}
else
{
    Console.WriteLine("The word is not a palindrome.");
}