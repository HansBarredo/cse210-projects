using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        ScriptureDepository library = new ScriptureDepository();

        library.AddScripture(new Reference("1 Nephi", 3, 7), 
            "I will go and do the things which the Lord hath commanded; for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
        library.AddScripture(new Reference("2 Nephi", 2, 25), 
            "Adam fell that men might be; and men are, that they might have joy.");
        library.AddScripture(new Reference("Mosiah", 2, 17), 
            "When ye are in the service of your fellow beings ye are only in the service of your God.");
        library.AddScripture(new Reference("Ether", 12, 27), 
            "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        library.AddScripture(new Reference("Doctrine and Covenants", 4, 2), 
            "Therefore, O ye that embark in the service of God, see that ye serve him with all your heart, might, mind, and strength, that ye may stand blameless before God at the last day.");
        library.AddScripture(new Reference("Doctrine and Covenants", 6, 36), 
            "Look unto me in every thought; doubt not, fear not.");
        library.AddScripture(new Reference("Moses", 1, 39), 
            "For behold, this is my work and my glory—to bring to pass the immortality and eternal life of man.");

        Scripture _scripture = library.SelectRandomScripture();

        while (!_scripture.isCompletelyHidden())
        {
            Console.Clear();
            _scripture.DisplayScripture();

            Console.WriteLine("\nPress Enter to hide 3 more words or type 'quit' to exit.");
            string input = Console.ReadLine()?.Trim().ToLower();
            if (input == "quit" || _scripture.HideRandomWords(3))
            {
                break; // Exit the main loop
            }
        }

        Console.WriteLine("\nProgram finish");
    }
}