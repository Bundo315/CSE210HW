using System;
class Program
{
    static void Main(string[] args)
    {

        Journal journal = new Journal();
        Console.WriteLine("Welcome to the program ");

        int x = 0;
        while (x != 1)
        {
            //choices
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please choose one of the options: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {   
                //Write a new entry into the journal
                case 1:
                    journal.NewEntry();
                    Console.WriteLine();
                    break;
                //Display the journal
                case 2:
                    journal.DisplayEntries();
                    Console.WriteLine();
                    break;
                //Load the file where the journal is saved
                case 3:
                    Console.Write("Enter the file name you want to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadEntries(loadFileName);
                    Console.WriteLine();
                    break;
                //Save the journal to a csv file
                case 4:
                    Console.Write("Enter the file name you want to save: ");
                    string saveFileName = Console.ReadLine();
                    journal.SaveEntries(saveFileName);
                    Console.WriteLine("Successfully saved");
                    Console.WriteLine();
                    break;
                //Quit the program
                case 5:
                    x = 1;
                    Console.WriteLine("Exited the program.");
                    Console.WriteLine();
                    break;
                //Entered a invalid choice
                default:
                    Console.WriteLine("Invalid input. Please choose a integer between 1 and 5.");
                    break;
            }
        }
    }
}