class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John 3:16");
        List<Word> words = new List<Word>
        {
            new Word("For"),
            new Word("God"),
            new Word("so"),
            new Word("loved"),
            new Word("the"),
            new Word("world,"),
            new Word("that"),
            new Word("he"),
            new Word("gave"),
            new Word("his"),
            new Word("only"),
            new Word("Son,")
        };

        Scripture scripture = new Scripture(reference, words);

        do
        {
            Console.Clear();
            scripture.Display();

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to end.");
            string input = Console.ReadLine();

            if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
                break;

            scripture.HideRandomWords(2); // Hide 2 random words
        } while (!scripture.AllWordsHidden());
    }
}
