using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    private Reference reference;
    private List<Word> words;

    public Scripture(Reference refObj, string scriptureText)
    {
        reference = refObj;
        words = scriptureText.Split(' ').Select(wordText => new Word(wordText)).ToList();
    }

    public void HideRandomWord()
    {
        var wordsToHide = words.Where(word => !word.IsHidden).ToList();

        if (wordsToHide.Count > 0)
        {
            Random random = new Random();
            int index = random.Next(wordsToHide.Count);
            wordsToHide[index].Hide();
        }

    }

    public bool IsHidden(string word) 
    {
        return words.Any(w => w.Text == word && w.IsHidden);
    }

    public string RenderDisplay()
    {
        string displayText = string.Join(" ", words.Select(word => word.IsHidden ? new string('_', word.Text.Length) : word.Text));
        return displayText;
    }

    public bool IsComplete()
    {
        return words.All(word => word.IsHidden);
    }

    public string IsCorrect(string input)
    {
        string fullText = string.Join(" ",words.Select(word => word.Text));
        if (input == fullText)
        {
            return "yay you got it";
        }
        else
        {
            return "try again";
        }
    }
}


