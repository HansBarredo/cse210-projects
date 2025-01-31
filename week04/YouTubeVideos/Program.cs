using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# for Beginners", "Hans", 600);
        Video video2 = new Video("Advanced C# Techniques", "Alice", 1200);
        Video video3 = new Video("C# Data Structures", "John", 900);

        video1.AddComment(new Comment("CodeMaster99", "Great tutorial!"));
        video1.AddComment(new Comment("DevSophieX", "Very helpful, thanks!"));
        video1.AddComment(new Comment("JakeTheCoder", "Can you do one on LINQ?"));

        video2.AddComment(new Comment("LunaTechie", "This made my project easier!"));
        video2.AddComment(new Comment("KevDev42", "I finally understand delegates."));
        video2.AddComment(new Comment("EmmaCodes", "Clear and well explained!"));

        video3.AddComment(new Comment("ChrisTheDev", "Love how you explain dictionaries!"));
        video3.AddComment(new Comment("DataDave77", "Can you cover linked lists next?"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);


        foreach (var video in videos)
        {
            Console.WriteLine(video.DisplayText());
            Console.WriteLine(new string('-', 40));
        }
    }
}