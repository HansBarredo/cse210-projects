using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }
    public void DisplayScripture()
    {
        Console.Write(_reference.ToString());

        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();

    }

    public bool HideRandomWords(int numberToHide)
    {
        List<int> randomNumbers = new List<int>();
        Random random = new Random();

        while (!isCompletelyHidden())
        {
            Console.Clear();

            int wordsHiddenThisRound = 0;

            while (wordsHiddenThisRound < numberToHide)
            {
                if (_words.Count - randomNumbers.Count <= 0)
                    break;

                int randomIndex = random.Next(_words.Count);

                if (!randomNumbers.Contains(randomIndex) && !_words[randomIndex].IsHidden())
                {
                    _words[randomIndex].Hide();
                    randomNumbers.Add(randomIndex);
                    wordsHiddenThisRound++;
                }
            }

            DisplayScripture();

            if (!isCompletelyHidden())
            {
                Console.WriteLine("\nPress Enter to hide 3 more words or type 'quit' to exit.");
                string input = Console.ReadLine()?.Trim().ToLower();

                if (input == "quit")
                {
                    return true; 
                }
            }
        }

        return false; 
    }


    public bool isCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}
