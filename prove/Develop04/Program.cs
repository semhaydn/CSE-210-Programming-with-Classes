using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {   
                Console.Clear(); // Clear the console
                BreathingActivity breathingActivity = new BreathingActivity("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing Activity");
                breathingActivity.StartActivity();
                breathingActivity.RunActivity();
                breathingActivity.EndActivity();
            }
            else if (choice == 2)
            {   
                Console.Clear(); // Clear the console
                ReflectionActivity reflectionActivity = new ReflectionActivity("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflection Activity");
                reflectionActivity.StartActivity();
                reflectionActivity.RunActivity();
                reflectionActivity.EndActivity();
            }
            else if (choice == 3)
            {   
                Console.Clear(); // Clear the console
                ListingActivity listingActivity = new ListingActivity("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing Activity");
                listingActivity.StartActivity();
                listingActivity.RunActivity();
                listingActivity.EndActivity();
            }
            else if (choice == 4)
            {
                break; // Exit the program
            }
        }
    }
}
