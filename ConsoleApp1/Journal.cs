using System.Runtime.CompilerServices;

namespace ConsoleApp1;


// The journal file manages all of the 
public class Journal
{

    private string filePath;
    private Entry[] entries;
    // load entries from the file

    public Journal(string filePath)
    {
        Entry secondEntry = new Entry("Short placeholder prompt", DateTime.Now, "whatever the user put in :)");
        this.filePath = filePath;
        
        // write code to parse entries from the journal file, then add them to this.entries
        
    }
    
    // Create a new entry with a random prompt and manage user response 

    public void CreateEntry()
    {
        Entry newEntry = new Entry("Who was the most interesting person I interacted with today?", DateTime.Now);

        // write code here to handle getting user response.
        
        newEntry.ModifyEntry("myself");

        this.entries.Append(newEntry);

    }
    
    // an array of Entry, parsed from the journal file

    public Entry[] GetEntries()
    {
        return entries;
    }

    public void SaveEntries()
    {
        // code to save the list of entries to the journal file
    }
}