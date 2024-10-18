using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    public string GetDisplayText()
    {
        string scriptureText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetReferenceString()}\n{scriptureText}";
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int wordsToHide = 3; // Number of words to hide in each iteration

        var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
        if (visibleWords.Count > 0)
        {
            for (int i = 0; i < wordsToHide && visibleWords.Count > 0; i++)
            {
                int randomIndex = random.Next(visibleWords.Count);
                visibleWords[randomIndex].Hide();
                visibleWords.RemoveAt(randomIndex);
            }
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
