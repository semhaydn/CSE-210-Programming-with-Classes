using System;

namespace JournalProgram
{
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
}
