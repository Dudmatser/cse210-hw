using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        int guess = -1;
        int total = 1;
        while (guess != number)
{
    Console.Write("Guess a random number: ");
    guess = int.Parse(Console.ReadLine());

    if (guess < number)
    {
    Console.Write("Higher\n");
    total = total +1;
    }
    else if (guess > number)
    {
    Console.Write("Lower\n");
    total = total +1;

    }
    else 
    {
    Console.Write("you got it right!");
    Console.Write($"You guessed {total} times.");
    }
}
        
    }
}