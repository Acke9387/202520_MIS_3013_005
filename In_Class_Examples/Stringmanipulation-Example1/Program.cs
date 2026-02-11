
string sentence = "There's an art to getting your way, and spitting olive pits across the table isn't it.";

int numberOfLetters = sentence.Length;
char firstLetter = sentence[0];
char lastLetter = sentence[numberOfLetters - 1];

Console.WriteLine($"The first letter is {firstLetter} and the last letter is {lastLetter}");

Console.WriteLine($"The sentence has {numberOfLetters} in it.");

sentence = sentence.ToUpper();
// Output every other letter of the sentence
for (int i = 0; i < sentence.Length; i = i + 1)
{
    Console.WriteLine(sentence[i]);
}