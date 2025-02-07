using System;
using System.IO;


public class Journal
{
    // List to store multiple journal entries
    public List<Entry> _entries = new List<Entry>();

    // Method to create a new journal entry
    public void NewEntry()
    {
        Entry entry = new Entry(); // Create a new Entry object
        entry.MakeDate(); // Set the current date for the entry
        entry.MakePrompt(); // Generate a random prompt for the entry
        entry.GetResponse(); // Capture the user's response to the prompt
        _entries.Add(entry); // Add the new entry to the list of entries
    }

    // Method to display all journal entries
    public void DisplayEntries()
    {
        foreach (Entry entry in _entries) // Iterate through each entry in the list
        {
            Console.WriteLine($"Date: {entry._date}"); // Display the date of the entry
            Console.WriteLine($"Prompt: {entry._prompt}"); // Display the prompt of the entry
            Console.WriteLine($"{entry._response}"); // Display the user's response
            Console.WriteLine(); // Add a blank line for readability
        }
    }

    // Method to load entries from a file
    public void LoadEntries(string filename)
    {
        if (filename == "journal.csv") // Check if the file is a CSV file named "journal.csv"
        {
            string[] lines = File.ReadAllLines(filename); // Read all lines from the file
            foreach (string line in lines) // Iterate through each line in the file
            {
                string[] parts = line.Split(","); // Split the line by commas into parts
                string date = parts[0]; // Extract the date from the first part
                string prompt = parts[1]; // Extract the prompt from the second part
                string response = parts[2]; // Extract the response from the third part

                // Display the loaded entry details
                Console.WriteLine($"Date: {date}"); 
                Console.WriteLine($"Prompt: {prompt}"); 
                Console.WriteLine($"{response}"); 
                Console.WriteLine(); 
            }
        }
    }

    // Method to save entries to a file
    public void SaveEntries(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename, true)) // Open the file for appending
        {
            if (filename.EndsWith(".csv")) // Check if the file is a CSV file
            {
                foreach (Entry entry in _entries) // Iterate through each entry in the list
                {
                    // Write the entry details in CSV format
                    outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}"); 
                }
            }
            
        }
    }
}
