
using System.IO;
using ConsoleApp1;

class Program
{
    // Entry point for the program
    public static void Main(String[] args)
    {
        Journal currentJournal = null;
        // action is the action from the prompt. action 3 is set first to force the user to load a journal file before doing anything else,
        // because it wouldn't make sense to provide options like display journal file.
        int action = 3;
        
        
        // if action == 5, then the program stops. hence we use action != because we want it to run if action is not 5
        while (action != 5)
        {
            switch (action)
            {
                case 3:
                    // Load journal file (or create new if it doesn't exist)
                    Console.WriteLine("Please type the path of the file:");
                    string filePath = Console.ReadLine();
                    currentJournal = new Journal(filePath);
                    break;
                case 2:
                    // Display journal entries
                    currentJournal.GetEntries();
                    break;
                case 1:
                    // Write a new entry
                    currentJournal.CreateEntry();
                    break;
                case 4:
                    // Save the journal file
                    currentJournal.SaveEntries();
                    break;
            }

            Console.WriteLine("Welcome to the Journal program. Please choose one of the following options:");
            Console.WriteLine("1. Write new prompt");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Load journal file");
            Console.WriteLine("4. Save journal file");
            Console.WriteLine("5. Quit");
            action = Convert.ToInt32(Console.ReadLine());
        }

    }

}