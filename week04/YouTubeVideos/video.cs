using System.IO;

public class Video
{

    private string _title;
    private string _author;
    private int _length;
    private int _commentNum;
    private string _filename = "videos.txt";
    private List<string> _videos = new List<string>();

    public Video(string title, string author, int length, int commentNum)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentNum = commentNum;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"{_title} - {_author}: {_length} seconds | {_commentNum} comments.");
    }

    public void SaveVideoAndComment()
    {
        _videos.Add(_title);
        _videos.Add(_author);
        _videos.Add(_length.ToString());
        _videos.Add(_commentNum.ToString());
        using (StreamWriter _outputFile = new StreamWriter(_filename, append: true))
        {
            _outputFile.WriteLine($"{_author} - {_title}: {_length} seconds | {_commentNum} comments.");
        }
    }

    public int GetNumberOfComments()
    {
        return _commentNum;
    }

}