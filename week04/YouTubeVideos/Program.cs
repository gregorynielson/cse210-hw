using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Video vid1 = new Video("Miracle Movie Trailer", "Disney", 450, 3);
        Comment com1 = new Comment(vid1);
        vid1.DisplayVideoInfo();
        vid1.SaveVideoAndComment();
        com1.DisplayComments();
        Console.WriteLine("");

        Video vid2 = new Video("How 'Cars' Was Made", "Pixar Studios", 1245, 4);
        Comment com2 = new Comment(vid2);
        vid2.DisplayVideoInfo();
        vid2.SaveVideoAndComment();
        com2.DisplayComments();
        Console.WriteLine();

        Video vid3 = new Video("Best of Bugs Bunny and Elmer Fudd", "Looney Tunes", 835, 4);
        Comment com3 = new Comment(vid3);
        vid3.DisplayVideoInfo();
        vid3.SaveVideoAndComment();
        com3.DisplayComments();
        Console.WriteLine("");

        Video vid4 = new Video("Everytime Tom Caught Jerry", "Hanna Barbera", 945, 3);
        Comment com4 = new Comment(vid4);
        vid4.DisplayVideoInfo();
        vid4.SaveVideoAndComment();
        com4.DisplayComments();
        Console.WriteLine();
    }
}