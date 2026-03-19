using System.IO;

public class Journal
{
    
    public string _date;
    public string _entry;
    public List<string> _entries = new List<string>();

    public void DisplayEntries()
    {
        foreach (string _entry in _entries)
        {
            Console.WriteLine($"{_entry}");
        }
    }
    public void SaveEntry()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string _entry in _entries)
            {
                outputFile.WriteLine(_entry);
            }
        }
        
    }
    public void LoadEntries()
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            _entries.Add(line);
        }
    }

    public string GetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        string _date = theCurrentTime.ToShortDateString();
        return _date;
    }
}