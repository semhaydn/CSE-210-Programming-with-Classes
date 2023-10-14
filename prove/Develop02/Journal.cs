using System;
using System.Collections.Generic;
using System.IO;

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
}
