using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Video> videos = new List<Video>();

        Video vid1 = new Video("Miracle Movie Trailer", "Disney", 450);
        Comment com1 = new Comment("Dopey", "This is silly.");
        Comment com2 = new Comment("Sneezy", "This is sick!");
        Comment com3 = new Comment("Bashful", "This is embarrassing.");
        vid1.comments.Add(com1);
        vid1.comments.Add(com2);
        vid1.comments.Add(com3);
        videos.Add(vid1);

        Video vid2 = new Video("How 'Cars' Was Made", "Pixar Studios", 1245);
        Comment com4 = new Comment("Happy", "This is so fun.");
        Comment com5 = new Comment("Sleepy", "This is boring.");
        Comment com6 = new Comment("Doc", "Very insightful!");
        vid2.comments.Add(com4);
        vid2.comments.Add(com5);
        vid2.comments.Add(com6);
        videos.Add(vid2);

        Video vid3 = new Video("Best of Bugs Bunny and Elmer Fudd", "Looney Tunes", 835);
        Comment com7 = new Comment("Daffy", "Not as funny as me");
        Comment com8 = new Comment("Road Runner", "Meep Meep");
        Comment com9 = new Comment("Lola", "Go Bugs, Go!");
        vid3.comments.Add(com7);
        vid3.comments.Add(com8);
        vid3.comments.Add(com9);
        videos.Add(vid3);

        Video vid4 = new Video("Every Time Tom Caught Jerry", "Hanna Barbera", 945);
        Comment com10 = new Comment("Scooby", "Ruh, Roh!");
        Comment com11 = new Comment("Shaggy", "This is making me hungry.");
        Comment com12 = new Comment("Freddy", "I wonder if their house is haunted");
        vid4.comments.Add(com10);
        vid4.comments.Add(com11);
        vid4.comments.Add(com12);
        videos.Add(vid4);

        foreach (Video video in videos)
        {
            Console.WriteLine($"{video._title} - {video._author}: {video._length} seconds.");
            Console.WriteLine("3 Comments:");

            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($"{comment._name} - {comment._comment}");
            }
            Console.WriteLine("");
        }
        

        // Video vid2 = new Video("How 'Cars' Was Made", "Pixar Studios", 1245, 4);
        // Comment com2 = new Comment(vid2);
        // vid2.DisplayVideoInfo();
        // vid2.SaveVideoAndComment();
        // com2.DisplayComments();
        // Console.WriteLine();

        // Video vid3 = new Video("Best of Bugs Bunny and Elmer Fudd", "Looney Tunes", 835, 4);
        // Comment com3 = new Comment(vid3);
        // vid3.DisplayVideoInfo();
        // vid3.SaveVideoAndComment();
        // com3.DisplayComments();
        // Console.WriteLine("");

        // Video vid4 = new Video("Everytime Tom Caught Jerry", "Hanna Barbera", 945, 3);
        // Comment com4 = new Comment(vid4);
        // vid4.DisplayVideoInfo();
        // vid4.SaveVideoAndComment();
        // com4.DisplayComments();
        // Console.WriteLine();
    }
}