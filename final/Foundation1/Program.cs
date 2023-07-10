using System;

class Program
{
    static void Main(string[] args)
    {
        List<Comment> comments1 = new List<Comment>
        {
            new Comment("Jul-6-2023", "ubuntu", "randalf stopped by"),
            new Comment("Jul-7-2023", "vuduguy", "Love it, I could watch it all day long"),
            new Comment("Jul-8-2023", "Anonymous", "Don't know how I got here but it is not bad")
        };

        Video video1 = new Video("Hello world", "Great Randalf", 200, comments1);

        List<Comment> comments2 = new List<Comment>
        {
            new Comment("Jul-9-2023", "Armageddon", "Greate background music"),
            new Comment("Jul-9-2021", "Josepuntu", "He did not die, did he?"),
            new Comment("Jul-10-2023", "Joyce", "The beginning of the end")
        };

        Video video2 = new Video("Running Cat", "Cat", 340, comments2);

        List<Video> videos = new List<Video> { };

        videos.Add(video1);
        videos.Add(video2);

        foreach (Video video in videos)
        {
            Console.WriteLine(video.GetVideo());
            Console.Write("Number of comments:");
            Console.WriteLine(video.GetCommentCount());
            video.DisplayComments();
            Console.WriteLine("");
        }
    }
}
