using System;

class Program
{
    static void Main(string[] args)
    {
        var videos = new List<Video>
        {
            new Video("Video 1", "Author 1", 120),
            new Video("Video 2", "Author 2", 180),
            new Video("Video 3", "Author 3", 240),
            new Video("Video 4", "Author 4", 300)
        };

        videos[0].AddComment("User 1", "Great video!");
        videos[0].AddComment("User 2", "Interesting content.");
        videos[0].AddComment("User 3", "Could be better.");

        videos[1].AddComment("User 4", "Nice job!");
        videos[1].AddComment("User 5", "I learned a lot.");
        videos[1].AddComment("User 6", "Keep up the good work.");

        videos[2].AddComment("User 7", "Very informative.");
        videos[2].AddComment("User 8", "Thanks for sharing.");
        videos[2].AddComment("User 9", "I enjoyed watching this.");

        videos[3].AddComment("User 10", "Fascinating.");
        videos[3].AddComment("User 11", "Could you make more videos like this?");
        videos[3].AddComment("User 12", "I'll share this with my friends.");

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}