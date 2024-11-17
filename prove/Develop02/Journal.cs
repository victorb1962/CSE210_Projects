using System;

// A code template for the category of things known as Journal
public class Journal
{
    // member variables
    // The C# convention is to start member variables with an underscore _
    public List<JournalEntry> _journal = new List<JournalEntry>();
    private string _userFileName;

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Journal()
    {
    }

    // A method that displays journal entries 
    public void Display()
    {
        foreach (JournalEntry journalEntry in _journal)
        {
            journalEntry.Display();
        }
    }

    // A method to create a journal from a text file 
    public void CreateJournalFile()
    {
        Console.Write("What is the file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (!File.Exists(_userFileName))
        {
            File.CreateText(_userFileName);
            Console.Write($"\n*** {_userFileName} has been created! ***\n");
            Console.Write("*** Your journal entries have been saved. ***\n");
            SaveJournalFile(_userFileName);
        }
        else
        {
            Console.Write($"\n*** {_userFileName} already exits. ***\n");
            Console.Write("*** Your journal entries have been added. ***\n");
            AppendJournalFile(_userFileName);
        }
    }

    // A method to save journal to a text file 
    public void SaveJournalFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    // A method to append a new entry to the journal text file 
    public void AppendJournalFile(string _userFileName)
    {
        using (StreamWriter outputFile = new StreamWriter(_userFileName, append: true))
        {
            foreach (JournalEntry journalEntry in _journal)
            {
                outputFile.WriteLine($"{journalEntry._entryNumber}; {journalEntry._dateTime}; {journalEntry._journalPrompt}; {journalEntry._journalEntry}");
            }
        }
    }

    // A method to check for the text file and load it into the list.  
    // To replace any current entries in the list
    public void LoadJournalFile()
    {
        Console.Write("What is the file name? ");
        string userInput = Console.ReadLine();
        _userFileName = userInput + ".txt";

        if (File.Exists(_userFileName))
        {
            List<string> readText = File.ReadAllLines(_userFileName).Where(arg => !string.IsNullOrWhiteSpace(arg)).ToList();
            foreach (string line in readText)
            {
                string[] entries = line.Split("; ");

                JournalEntry entry = new JournalEntry();

                entry._entryNumber = entries[0];
                entry._dateTime = entries[1];
                entry._journalPrompt = entries[2];
                entry._journalEntry = entries[3];

                _journal.Add(entry);
            }
        }
    }

}