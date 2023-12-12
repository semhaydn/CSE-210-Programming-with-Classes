using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating activities
        Activity runningActivity = new Running("03 Nov 2022", 30, 3.0);
        Activity cyclingActivity = new Cycling("03 Nov 2022", 30, 15.0);
        Activity swimmingActivity = new Swimming("03 Nov 2022", 30, 10);

        // Putting activities in a list
        List<Activity> activities = new List<Activity>
        {
            runningActivity,
            cyclingActivity,
            swimmingActivity
        };

        // Displaying activity summaries
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
