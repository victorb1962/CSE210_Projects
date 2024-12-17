using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();  // Clear the console
        Console.Write("*** Welcome to the Exercise Tracking App ***\n");
        Console.Write("\nSummary of your execises:\n");

        List<Activity> activitiesList = new List<Activity>();
        activitiesList.Add(new RunningActivity("03 Nov 2024", 30, 3));   // Run    3 miles in 30 min
        activitiesList.Add(new CyclingActivity("18 Jul 2024", 30, 14));  // Cycle 14 mph   in 30 min 
        activitiesList.Add(new SwimmingActivity("16 Dec 2024", 30, 30)); // Swim  30 laps  in 30 min, 50 meters a lap (covert to miles)
        foreach (Activity a in activitiesList)
        {
            a.Summary();
        }
    }
}