using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job(); //create a job instance
        job1._jobtitle = "Software Enigneer";
        job1._company = "Microsoft";
        job1._startyear = 2019;
        job1._endyear = 2022;


        Job job2 = new Job(); //create another job insatnce
        job2._jobtitle = "Manager";
        job2._company = "Apple";
        job2._startyear = 2022;
        job2._endyear = 2023;


        Resume resume = new Resume(); //create a resume instance
        resume._name = "Nathan Howarth";

        resume._jobs.Add(job1);//add the jobs to the list in the resume class
        resume._jobs.Add(job2);

        resume.Display();//display my information
       
    }
}