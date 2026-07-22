using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        Video video1 = new Video(
            "Introduction to C# Programming",
            "Alfred Igba",
            600
        );

        video1.AddComment(new Comment("John", "This is a very helpful introduction."));
        video1.AddComment(new Comment("Mary", "I learned a lot from this video."));
        video1.AddComment(new Comment("David", "The explanation was easy to understand."));

        Video video2 = new Video(
            "Understanding Abstraction in Programming",
            "John Reading",
            900
        );

        video2.AddComment(new Comment("Peter", "The explanation was excellent."));
        video2.AddComment(new Comment("Sarah", "This video helped me understand abstraction."));
        video2.AddComment(new Comment("Michael", "The video explained abstraction very well."));
        video2.AddComment(new Comment("Grace", "I am looking forward to the next lesson."));

        Video video3 = new Video(
            "How to Build Your First C# Program",
            "John Reading",
            750
        );

        video3.AddComment(new Comment("James", "This tutorial was very useful."));
        video3.AddComment(new Comment("Linda", "I finally understand how C# programs work."));
        video3.AddComment(new Comment("Daniel", "Great video for beginners."));

        // Put all videos in a list
        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        // Display information about each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}