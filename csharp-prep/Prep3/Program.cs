using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        // Variables
        string userMagicNumber;
        string userGuess;
        int number;
        int guess;
        int count;
        string repeat;

        /* --- START OF COMMENT BLOCK ---
        // Core Requirement 1
        
        // Ask the user for the magic number
        Console.Write("What is the magic number? ");
        userMagicNumber = Console.ReadLine();
        number = int.Parse(userMagicNumber);
        
        // Ask the user to guess
        Console.Write("What is your guess? ");
        userGuess = Console.ReadLine();
        guess = int.Parse(userGuess);

        if (guess < number)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > number)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

        // Core Requirement 2
        // Add a loop until the correct answer.

        // Ask the user for the magic number
        Console.Write("What is the magic number? ");
        userMagicNumber = Console.ReadLine();
        number = int.Parse(userMagicNumber);
        
        // Ask the user to guess
        Console.Write("What is your guess? ");
        userGuess = Console.ReadLine();
        guess = int.Parse(userGuess);

        while (guess != number)
        {
            if (guess < number)
            {
                Console.WriteLine("Higher");

                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");

                Console.Write("What is your guess? ");
                userGuess = Console.ReadLine();
                guess = int.Parse(userGuess);
            }
        }
        Console.WriteLine("You guessed it!");

        --- END OF COMMENT BLOCK --- */

        // Core Requirement 3
        // Instead of having the user supply the magic number, generate a random number from 1 to 100.
        
        repeat = "Y";
        while (repeat == "Y" || repeat == "y")
        {
            // Add random number generator 
            Random randomGenerator = new Random();
            number = randomGenerator.Next(1, 100);

            Console.Write("Pick a number between 1 and 100:  ");
            userGuess = Console.ReadLine();
            guess = int.Parse(userGuess);

            count = 1;
            while (guess != number)
            {
                count++; 
                if (guess < number)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    userGuess = Console.ReadLine();
                    guess = int.Parse(userGuess);
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    userGuess = Console.ReadLine();
                    guess = int.Parse(userGuess);
                }
            }
            Console.WriteLine("You guessed it!");

            // Stretch 1 - Keep track of how many guesses 
            Console.WriteLine($"You took {count} guesses.");

            // Stretch 2 - ask the user if they want to play again?
            Console.Write("Do you want to play again? Y/N ");
            repeat = Console.ReadLine();
        }
    }
}