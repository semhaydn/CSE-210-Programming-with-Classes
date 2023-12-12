using System;

class Program
{
    static void Main()
    {
        // Creating addresses for events
        Address eventAddress = new Address("789 Maple St", "EventCity", "NY", "USA");

        // Creating events
        Event standardEvent = new Event("Standard Event", "A standard event description", "2023-12-31", "18:00", eventAddress);
        Lecture lectureEvent = new Lecture("Lecture on C# Programming", "Learn about C# programming", "2023-12-15", "14:00", eventAddress, "John Doe", 100);
        Reception receptionEvent = new Reception("Networking Reception", "An informal gathering for networking", "2023-12-20", "19:00", eventAddress, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Outdoor Concert", "Enjoy music under the stars", "2023-12-25", "20:30", eventAddress, "Clear sky");

        // Displaying event information
        DisplayEventInformation(standardEvent);
        DisplayEventInformation(lectureEvent);
        DisplayEventInformation(receptionEvent);
        DisplayEventInformation(outdoorEvent);
    }

    static void DisplayEventInformation(Event ev)
    {
        Console.WriteLine(ev.GenerateFullMessage());
        Console.WriteLine(ev.GenerateShortDescription());
        Console.WriteLine();
    }
}
