class Program
{
    static void Main()
    {
        // Example scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        while (true)
        {
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();

            if (scripture.AllHidden())
            {
                scripture.Display();
                Console.WriteLine("\nAll words are hidden. Program ending.");
                break;
            }
        }
    }
}