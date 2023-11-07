using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    public ReflectionActivity(string description, string activityName) : base(description, activityName)
    {
    }

    public override void RunActivity()
    {
        string[] prompts = {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        string[] questions = {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

        Random random = new();

        for (int i = 0; i < Duration; i++)
        {
            Console.Clear(); // Clear the console
            Console.WriteLine(prompts[random.Next(prompts.Length)]);
            Console.WriteLine("Press 'c' to continue when you have something in mind or 'q' to quit.");
            char keyChar;
            do
            {
                var key = Console.ReadKey();
                keyChar = key.KeyChar;
                if (keyChar == 'q' || keyChar == 'Q')
                {
                    return; // Exit the loop and the method if 'q' is pressed
                }
            } while (keyChar != 'c' && keyChar != 'C');
            Thread.Sleep(5000); // Pause for 5 seconds to let the user think

            foreach (string question in questions)
            {
                Console.Clear(); // Clear the console
                Console.WriteLine(question);
                Console.WriteLine("Press 'c' to continue when you have something in mind or 'q' to quit.");
                        Console.Write("Thinking... ");
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("/");
                    Thread.Sleep(300);
                    Console.Write("\b \b");
                    Console.Write("-");
                    Thread.Sleep(300);
                    Console.Write("\b \b");
                    Console.Write("\\");
                    Thread.Sleep(300);
                    Console.Write("\b \b");
                    Console.Write("|");
                    Thread.Sleep(300);
                    Console.Write("\b \b");
                }
                do
                {
                    var key = Console.ReadKey();
                    keyChar = key.KeyChar;
                    if (keyChar == 'q' || keyChar == 'Q')
                    {
                        return; // Exit the loop and the method if 'q' is pressed
                    }
                } while (keyChar != 'c' && keyChar != 'C');
                Thread.Sleep(3000); // Pause for 3 second
            }
        }
    }
} 