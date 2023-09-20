using System.Runtime.InteropServices.JavaScript;

namespace ConsoleApp1;

public class Entry
{
    private string prompt;
    private DateTime creationDate;
    private string response = "";
    
    
    // Constructor for Entry, used for making a new entry with no response.
    public Entry(string prompt, DateTime creationDate)
    {
        this.prompt = prompt;
        this.creationDate = creationDate;
    }

    
    // Constructor for Entry, should be used for parsing entries from the journal file (because there is already a response)
    public Entry(string prompt, DateTime creationDate, string reponse)
    {
        this.prompt = prompt;
        this.creationDate = creationDate;
        this.response = response;
    }

    // used after a new entry is created
    public void ModifyEntry(string response)
    {
        this.response = response;
    }

    // get prompt from the journal entry
    public string GetPrompt()
    {
        return prompt;
    }
    // get a response from the journal entry
    public string GetResponse()
    {
        return response;
    }

    public string GetDate()
    {
        return this.creationDate.ToShortDateString();
    }
    
}