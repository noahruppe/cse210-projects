using System;

public class Randomizer
{
    public List<Prompts>_Prompt = new List<Prompts>();

    public Random _random = new Random();

    public void AddPrompt (Prompts prompt)
    {
        _Prompt.Add(prompt);
    }

    public void DisplayRandomPrompt()
    {
        
        int RandomPromptIndex = _random.Next(_Prompt.Count);
        Prompts randomPrompt = _Prompt[RandomPromptIndex];

        string[] sentences = {
            randomPrompt._interestingPerson,
            randomPrompt._bestPartOfDay,
            randomPrompt._lordsHand,
            randomPrompt._emotionFelt,
            randomPrompt._doOver
        };

        int randomSentenceIndex = _random.Next(sentences.Length);
        string randomSentence = sentences[randomSentenceIndex];

        Console.WriteLine(randomSentence);
    }
}


