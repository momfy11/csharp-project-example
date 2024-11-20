// See https://aka.ms/new-console-template for more information
// hangman

using System.Diagnostics;


string[] possible_words = ["new", " console", "template", "https", "information"];
Random random_numbers = new();

string solution = possible_words[random_numbers.Next(0, possible_words.Length)];

string display = new('_', solution.Length);



Console.WriteLine(display);
char guess = get_user_guess();
bool guess_was_correct = false;

for (int i =0; i < solution.Length; i +=1)
{
    if (guess == solution[i])
    {
        display.Remove(i, 1);
        display.Insert(i, new string(guess));
        guess_was_correct = true;
    }
}

if (guess_was_correct)
{
    Console.WriteLine($"{guess} does not exist in the word");
}

char get_user_guess()
{
   string? guess == null;
    do
    {
        Console.WriteLine("Please enter a character to guess whit");
        string input = Console.ReadLine();
        Debug.Assert(input != null);
        if (input.Length == 1) { guess = input[0]; }
    } while (guess == 0);
    Debug.Assert(guess != null);
    return guess;
}