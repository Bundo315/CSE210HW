using System;

public class Resume //make a class for resumes
{
    public string _name; //To be able to make a name for my list

    public List<Job> _jobs = new List<Job>();//create the list

    public void Display() //function that displays new information and calls the old function to display my jobs
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job job in _jobs)
        {
            job.Display();//call the display function from Job.cs for each job in the list
        }
    }
}