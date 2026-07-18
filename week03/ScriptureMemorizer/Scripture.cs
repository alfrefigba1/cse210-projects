class Scripture
{
    private Reference reference;
    private List<Word> words;
    private Random random = new Random();

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(reference.ToString());
        Console.WriteLine(string.Join(" ", words.Select(w => w.Display())));
    }

    public void HideRandomWords(int count = 3)
    {
        var visibleWords = words.Where(w => !w.IsHidden).ToList();
        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public bool AllHidden()
    {
        return words.All(w => w.IsHidden);
    }
}