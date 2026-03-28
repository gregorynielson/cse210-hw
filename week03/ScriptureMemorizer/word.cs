

public class Word
{

    private Scripture _scripture;
    private List<string> _words = new List<string>()
    {

    };

    private List<int> _hiddenIndex = new List<int>()
    {

    };
    public Word(Scripture scrip1)
    {
        _scripture = scrip1;
    }

    private List<string> MakeScriptureList()
    {
        
        string text = _scripture.GetScriptureText();
        _words = text.Split(" ").ToList();
        return _words;
    }

    public void DisplayScripture()
    {
        _words = MakeScriptureList();
        foreach (string word in _words)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine("");
    }

    public List<string> HideRandomWord()
    {
        int hiddenWords = 0;
        Random random = new Random();
        while (hiddenWords < 3)
        {

            int randomIndex = random.Next(0, _words.Count);

            if (!_hiddenIndex.Contains(randomIndex))
            {
                _hiddenIndex.Add(randomIndex);



                string text = _words[randomIndex];
                string dashes = "_";
                while (dashes.Length != text.Length)
                {
                    dashes += "_";
                }
                _words[randomIndex] = text.Replace(text, dashes);
                hiddenWords++;
            }

        }
        foreach (string word in _words)
        {
            Console.Write($"{word} ");
        }
        Console.WriteLine("");
        return _words;
    }



}