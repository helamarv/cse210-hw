using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        int remainingWords = 0;
        
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                remainingWords++;
            }
        }
        
        int wordsToHide = Math.Min(3, remainingWords);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index;
            do
            {
                index = random.Next(_words.Count);
            } while (_words[index].IsHidden());
            _words[index].Hide();
        }
    }
    public bool IsCompletelyHidden()
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

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + " ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }
}