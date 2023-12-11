using System;
using System.Collections.Generic;

class Video
{
    // Attributes
    private string title;
    private string author;
    private int length;
    private List<Comment> comments;

    // Constructor
    public Video(string title, string author, int length)
    {
        this.title = title;
        this.author = author;
        this.length = length;
        this.comments = new List<Comment>();
    }

    // Methods
    public void AddComment(string commenter, string text)
    {
        Comment comment = new Comment(commenter, text);
        comments.Add(comment);
    }

    public int GetNumComments()
    {
        return comments.Count;
    }
}

class Comment
{
    // Attributes
    private string commenter;
    private string text;

    // Constructor
    public Comment(string commenter, string text)
    {
        this.commenter = commenter;
        this.text = text;
    }
}

class Program
{
    static void Main()
    {
        // Create a video
        Video myVideo = new Video("Introduction to Programming", "John Doe", 120);

        // Add comments
        myVideo.AddComment("User1", "Great video!");
        myVideo.AddComment("User2", "I learned a lot.");

        // Display video information
        Console.WriteLine($"Video: {myVideo.GetNumComments()} comments");
    }
}
