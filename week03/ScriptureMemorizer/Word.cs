class Word
{
    private string text;
    private bool hidden;

    public Word(string word)
    {
        text = word;
        hidden = false;
    }

    public bool IsHidden => hidden;

    public void Hide()
    {
        hidden = true;
    }

    public string Display()
    {
        return hidden ? new string('_', text.Length) : text;
    }
}