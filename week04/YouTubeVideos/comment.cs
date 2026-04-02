using System.IO;

public class Comment
{

    private Video _video;
    private string _filename = "comments.txt";
    private int _commentNum;
    private List<string> _comments = new List<string>();
    private List<string> _commentForVideo = new List<string>();
    private List<int> _usedIndex = new List<int>();


    public Comment(Video video)
    {
        _video = video;
    }


    public int SetNumberOfComments()
    {
        _commentNum = _video.GetNumberOfComments();
        return _commentNum;
    }
    

    public void CommentForVideo()
    {
        SetNumberOfComments();

        Random random = new Random();
        int usedComment = 0;
        string[] comments = System.IO.File.ReadAllLines(_filename);
        foreach (string comment in comments)
        {
            _comments.Add(comment);
        }
        while (usedComment < _commentNum)
        {

            int _randomIndex = random.Next(0, _comments.Count);

            if (!_usedIndex.Contains(_randomIndex))
            {
                _usedIndex.Add(_randomIndex);

                _commentForVideo.Add(_comments[_randomIndex]);

                usedComment++;
            }

        }
    }

    public void DisplayComments()
    {
        CommentForVideo();
        foreach (string _comment in _commentForVideo)
        {
            Console.WriteLine($"{_comment}");
        }
    }


}