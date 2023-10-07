using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JournalProgram
{
    class Journal
    {
        public List<Entry> Entries { get; } = new List<Entry>();

        public void AddEntry(string prompt, string response, DateTime date)
        {
            Entries.Add(new Entry(prompt, response, date));
        }

        public void DisplayEntries()
        {
            foreach (var entry in Entries)
            {
                Console.WriteLine($"Date: {entry.Date}");
                Console.WriteLine($"Prompt: {entry.Prompt}");
                Console.WriteLine($"Response: {entry.Response}\n");
            }
        }

        public void SaveToFile(string fileName)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{entry.Date.ToString("yyyy-MM-dd HH:mm:ss")}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved to file successfully.");
        }

        public void LoadFromFile(string fileName)
        {
            Entries.Clear();
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        if (DateTime.TryParse(parts[0], out DateTime date))
                        {
                            string prompt = parts[1];
                            string response = parts[2];
                            Entries.Add(new Entry(prompt, response, date));
                        }
                    }
                }
            }
            Console.WriteLine("Journal loaded from file successfully.");
        }
    }

    class Entry
    {
        public string Prompt { get; }
        public string Response { get; }
        public DateTime Date { get; }

        public Entry(string prompt, string response, DateTime date)
        {
            Prompt = prompt;
            Response = response;
            Date = date;
        }
    }

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
