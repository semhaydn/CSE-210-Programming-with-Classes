using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int guess;
        int attempts = 0;

        while (true)
        {
            int magic_number = randomGenerator.Next(1, 100);

            Console.Write("Do you want to play? (yes/no): ");
            string response = Console.ReadLine().ToLower();

            if (response == "no")
            {
                Console.WriteLine("Thank you for playing. Goodbye!");
                break;
            }
            else if (response != "yes")
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }
            else
            {
                Console.WriteLine("Let's play!");

                do
                {
                    Console.Write("What is your guess? ");
                    string y = Console.ReadLine();
                    guess = int.Parse(y);

                    if (magic_number > guess)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (magic_number < guess)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                        break; // Exit the game loop if the guess is correct
                    }

                    attempts++;
                } while (true); // Infinite loop for guessing

                Console.WriteLine($"It took you {attempts} attempts to guess the number.");
            }
        }
    }
}
