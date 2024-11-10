using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        string userNumber;
        int number = -1;

        List<int> numbers = new List<int>();

        while (number != 0)
        {
            Console.Write("Enter number (0 to quit): ");
            userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // Compute the sum
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");

        // Compute the average
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");

        // Find the maximum
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");
    }
}