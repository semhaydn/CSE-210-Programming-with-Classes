using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Creating videos and adding comments
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "Interesting content."));
        videos.Add(video1);

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment(new Comment("User3", "Loved it!"));
        video2.AddComment(new Comment("User4", "Keep it up."));
        videos.Add(video2);

        Video video3 = new Video("Video 3", "Author 3", 150);
        video3.AddComment(new Comment("User5", "Nice explanation."));
        videos.Add(video3);

        // Displaying video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
