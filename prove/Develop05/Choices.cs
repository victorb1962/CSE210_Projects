using System;

public class Choices
{
    // Attributes 
    private string _menu = $@"
Menu Options:
===========================================
  1. Start breathing activity
  2. Start reflecting activity
  3. Start listing activity
  4. Quit
===========================================
Select a choice from the menu: ";

    public string _userInput;
    private int _userChoice = 0;

    // Methods
    public int UserChoice()
    // Method to display choices
    {
        // Clear the console
        Console.Clear();
        Console.Write(_menu);

        _userInput = Console.ReadLine();
        _userChoice = 0;
        
        // This block catches any non integer values that are entered
        try
        {
            _userChoice = int.Parse(_userInput);
        }
        catch (FormatException)
        {
            _userChoice = 0;
        }
        catch (Exception exception)
        {
            Console.WriteLine(
                $"Unexpected error:  {exception.Message}");
        }
        return _userChoice;
    }

}