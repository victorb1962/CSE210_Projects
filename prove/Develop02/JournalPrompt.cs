using System;

// A code template for the category of things known as Journal Prompts
public class JournalPrompt
{
    // member variables
    // The C# convention is to start member variables with an underscore _

    public static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Did you read a book today? Tell me about it?",
        "What spiritual experiences did you have today?"
    };
    public List<string> _journalPrompt = new List<string>(_prompt);

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public JournalPrompt()
    {
    }

    // A method that displays a prompt question 
    public void Display()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        Console.WriteLine($"\n{_journalPrompt}");
    }

    // A method that gets a prompt question 
    public string GetPrompt()
    {
        var random = new Random();
        int index = random.Next(_journalPrompt.Count);
        string journalPrompt = _journalPrompt[index];
        return journalPrompt;
    }
}