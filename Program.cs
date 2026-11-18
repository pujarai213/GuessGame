
Console.WriteLine("Number Guessing Game");
Console.WriteLine("What is your name?");
string? name = Console.ReadLine();
Console.WriteLine($"Hello, {name}! I'm thinking of a number between 1 to 100.");

int secret = Random.Shared.Next(1, 101);
int maxAttempts = 7;
int attempts = 0;
bool won = false;

while (attempts < maxAttempts)
{
    Console.WriteLine($"Attempts {attempts+1}/{maxAttempts}. Your guess:");
    string? input = Console.ReadLine();

    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("Please type a whole number."); 
        continue;
    }

    attempts++;

    if(guess == secret)
    {
        won = true;
        break;
    }
    else if (guess < secret)
    {
        Console.WriteLine("Too Low!");
    }
    else
    {
        Console.WriteLine("Too high!");
    }
}
if (won)
    Console.WriteLine($"Correct, {name}! You got it in {attempts} attempts.");
else
    Console.WriteLine($"Out of attempts. The number was {secret}.");