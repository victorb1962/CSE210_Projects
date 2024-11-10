using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

         // Stretch Challenge
        string pos1 = answer.Substring(0, 1);
        int firstDigit = int.Parse(pos1);

        string pos2 = answer.Substring(1, 1);
        int lastDigit = int.Parse(pos2);
        // testing for digits
        // Console.WriteLine($"pos1 = {firstDigit}, pos2 = {lastDigit}");

        // Plus or Minus grade
        string ext;
        if ((firstDigit > 5 && firstDigit < 9) && lastDigit >= 7)
        {
            ext = "+";
        }
        else if ((firstDigit > 5 && firstDigit <= 9) && lastDigit < 3)
        {
            ext = "-";
        }
        else
        {
            ext = "";
        }

        Console.WriteLine($"You earned a letter grade of: {letter}{ext}");
        
        if (percent >= 70)
        {
            Console.WriteLine("Congratulations. You passed!");
        }
        else
        {
            Console.WriteLine("Sorry. You did not pass. Better luck next time!");
        }
    }
}