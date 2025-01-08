using System;

class Program
{
    static void Main(string[] args)
    {
        int guess;
        int counter;
        string playAgain;
        do{
            Console.Write("What is the magic number? ");
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            Console.WriteLine($"{number}");
            counter = 0;
        
            do{
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);

                if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

                counter++;
            } while (guess != number);

            Console.WriteLine($"Total number of guesses: {counter}");
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine().ToLower();

            if (playAgain == "no")
            {
                Console.WriteLine("Thanks for playing!");
            }

        } while (playAgain == "yes");
    }
}