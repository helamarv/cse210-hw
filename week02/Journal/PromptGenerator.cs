using System;

public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "What are you grateful for today?",
        "Describe a challenge you faced recently and how you overcame it.",
        "Write about a memorable moment from your childhood.",
        "What are your goals for the next month?",
        "Reflect on a recent accomplishment and how it made you feel."
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}