// A code template for the category of things known as Resume. The
// responsibility of a Resume is to hold and display a person's job information.

// Responsibility: Keep track of the person's name and a list of their jobs.
// Displays the resume, which shows the name first, followed by displaying each one of the jobs.

public class Resume
{
    // member variables
    // The C# convention is to start member variables with an underscore _
    public string _name = "";
    public List<Job> _jobs = new List<Job>();

    // A special method, called a constructor that is invoked using the  
    // new keyword followed by the class name and parentheses.
    public Resume()
    {
    }

    // A method that displays a person's resume 
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