using System.Collections.Generic;

public class Scripture
{

    private string[] scriptureParts;

    public string[] LoadRandomScripture()
    {

        string[] verses = File.ReadAllLines("verses.txt");
        Random random = new Random();
        int fileIndex = random.Next(verses.Length);
        string randomVerse = verses[fileIndex];

        scriptureParts = randomVerse.Split(new string[] {"|"}, StringSplitOptions.None);

        return scriptureParts;

        
    }

    public string GetScriptureText()
    {
        return scriptureParts[4];
    }

    public string[] GetScriptureParts()
    {
        scriptureParts = LoadRandomScripture();
        return scriptureParts;
    }
    

    
}