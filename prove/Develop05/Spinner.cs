using System;
using System.Diagnostics;

public class Spinner
{
    // Attributes 
    int counter;

    //Constructor
    // Methods
    public void Stopwatch()
    {
        Stopwatch timer = new Stopwatch();
        timer.Start();
        while (timer.Elapsed.TotalSeconds < 10)
        {
            Console.Write("+");

            Thread.Sleep(100);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
        }
        timer.Stop();
    }

    public void ShowSpinner()
    {
        var counter = 0;
        Console.Write("\n");
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            counter++;
            Thread.Sleep(100);
            Console.Write("\b \b"); // Erase the + character
        }
    }

    public void ShowSpinnerReady()
    {
        var counter = 0;
        Console.Write("Get Ready... \n");
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            counter++;
            Console.Write("\b \b"); // Erase the + character
            Thread.Sleep(100);
        }
    }

    public void ShowSpinnerDone()
    {
        Console.WriteLine();
        Console.Write("Well done!! \n");
        var counter = 0;
        for (int i = 0; i < 50; i++)
        {
            switch (counter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            counter++;
            Console.Write("\b \b"); // Erase the + character
            Thread.Sleep(100);
        }
    }

}