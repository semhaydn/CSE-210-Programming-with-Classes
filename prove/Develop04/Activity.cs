using System;
using System.Threading;

public abstract class Activity
{
    public int Duration { get; set; }
    public string Description { get; set; }
    public string ActivityName { get; set; }

    public Activity(string description, string activityName)
    {
        Description = description;
        ActivityName = activityName;
    }

    public void StartActivity()
    {
        Console.WriteLine(Description);
        Console.Write("Enter the duration (in seconds): ");
        Duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    public void EndActivity()
    {   
        Console.Clear(); // Clear the console
        Console.WriteLine($"Good job! You've completed the {ActivityName} in {Duration} seconds.");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    public abstract void RunActivity();
}
