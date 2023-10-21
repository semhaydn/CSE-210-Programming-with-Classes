public class Scripture
{
    public Reference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(Reference reference, List<Word> words)
    {
        Reference = reference;
        Words = words;
    }

    public void Display()
    {
        Console.WriteLine($"{Reference}:");
        foreach (var word in Words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

public void HideRandomWords(int count)
{
    Random random = new Random();
    List<Word> wordsToHide = Words.Where(word => !word.IsHidden).ToList();
    
    if (wordsToHide.Count < count)
    {
        Console.WriteLine("All words are already hidden.");
        return;
    }
    
    for (int i = 0; i < count; i++)
    {
        int randomIndex = random.Next(wordsToHide.Count);
        wordsToHide[randomIndex].Hide();
        wordsToHide.RemoveAt(randomIndex);
    }
}



    public bool AllWordsHidden()
    {
        return Words.All(word => word.IsHidden);
    }
}
