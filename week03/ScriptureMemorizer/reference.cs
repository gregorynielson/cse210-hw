

public class Reference
{

    // private string _allText;
    private string _book;
    private int _chapter;
    private int _verse;
    private string _endVerse;


    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int verse, string endVerse)
    {
        
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public void GetReferenceText()
    {
        Scripture scrip = new Scripture();
        string[] scriptureParts = scrip.GetScriptureParts();
        if (string.IsNullOrEmpty(_endVerse))
        {
            Console.Write($"{_book} {_chapter}: {_verse} ");
        } else {
            // _endVerse = int.Parse(scriptureParts[3]);
            Console.Write($"{_book} {_chapter}: {_verse}-{_endVerse} ");
        }
        
        
    }
}