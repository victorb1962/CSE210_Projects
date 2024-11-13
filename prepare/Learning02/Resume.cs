// Responsibility: Keep track of the person's name and a list of their jobs.
// Displays the resume, which shows the name first, followed by displaying each one of the jobs.
public class Resume
{
    // variables
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    public Resume()
    {
    }

    // Add a Display method
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach ( Job job in _jobs)
        {
            job.Display();
        }
    }
}