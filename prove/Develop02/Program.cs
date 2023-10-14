using System;
using System.Collections.Generic;

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal journal = new Journal();
            List<string> prompts = new List<string>
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
            };

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Journal Program Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Select a prompt (1-5):");
                            for (int i = 0; i < prompts.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {prompts[i]}");
                            }
                            if (int.TryParse(Console.ReadLine(), out int promptChoice) && promptChoice >= 1 && promptChoice <= 5)
                            {
                                Console.WriteLine("Enter your response:");
                                string response = Console.ReadLine();
                                journal.AddEntry(prompts[promptChoice - 1], response, DateTime.Now);
                                Console.WriteLine("Entry added successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Invalid prompt choice.");
                            }
                            break;
                        case 2:
                            journal.DisplayEntries();
                            break;
                        case 3:
                            Console.WriteLine("Enter a file name to save the journal:");
                            string saveFileName = Console.ReadLine();
                            journal.SaveToFile(saveFileName);
                            break;
                        case 4:
                            Console.WriteLine("Enter a file name to load the journal:");
                            string loadFileName = Console.ReadLine();
                            journal.LoadFromFile(loadFileName);
                            break;
                        case 5:
                            isRunning = false;
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid menu option.");
                }
            }
        }
    }
}
