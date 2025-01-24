using System;

public class Job //create a class named Job
        {
            public string _company; //create placeholders for my info
            public string _jobtitle;
            public double _startyear;
            public double _endyear;

            public void Display() //function to display my info when called
            {
                Console.WriteLine($"{_jobtitle} ({_company}) {_startyear}-{_endyear}");
            }
        }