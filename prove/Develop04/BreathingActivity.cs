using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity(string description, string activityName) : base(description, activityName)
    {
    }

    public override void RunActivity()
    {
        for (int i = 0; i < Duration; i++)
        {
            Console.Clear(); // Clear the console
            Console.Write("Breathe in");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(".");
                Thread.Sleep(700); // Pause for 1 second
            }
            Console.WriteLine();

            Thread.Sleep(2100); // Pause for 3 seconds

            Console.Clear(); // Clear the console
            Console.Write("Breathe out");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(".");
                Thread.Sleep(700); // Pause for 1 second
            }
            Console.WriteLine();

            Thread.Sleep(2100); // Pause for 4 seconds
        }
    }
}

