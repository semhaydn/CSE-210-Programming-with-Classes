using System;
using System.Threading;

public class ListingActivity : Activity
{
    public ListingActivity(string description, string activityName) : base(description, activityName)
    {
    }

    public override void RunActivity()
    {   
        Console.Clear(); // Clear the console
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random random = new Random();

        Console.WriteLine(prompts[random.Next(prompts.Length)]);
        Console.WriteLine($"You have {Duration} seconds to list as many items as you can.");

        DateTime endTime = DateTime.Now.AddSeconds(Duration);

        int numberOfItems = 0; // Initialize count to 0

        while (DateTime.Now < endTime)
        {
            // User can input items here
            string items = Console.ReadLine();
            numberOfItems++; // Increment count for each item entered
        }

        // Display the number of items entered
        Console.WriteLine($"You listed {numberOfItems} items.");
        
    }
}
