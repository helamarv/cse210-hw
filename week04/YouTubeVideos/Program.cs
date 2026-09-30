using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Create a video with comments
        Video video1 = new Video("My First Video", "John Doe", 120);
        Comment comment1 = new Comment("Alice", "Great video!");
        Comment comment2 = new Comment("Bob", "Thanks for sharing!");
        Comment comment3 = new Comment("Charlie", "I learned a lot from this video.");
        Comment comment4 = new Comment("David", "Looking forward to more content.");

        video1.AddComment(comment1, video1);
        video1.AddComment(comment2, video1);
        video1.AddComment(comment3, video1);
        video1.AddComment(comment4, video1);

        video1.DisplayVideoInfo();

        // Create another video with comments
        Video video2 = new Video("My Second Video", "Jane Smith", 180); 
        Comment comment5 = new Comment("Eve", "This video was very informative.");
        Comment comment6 = new Comment("Frank", "I appreciate the effort you put into this video.");
        Comment comment7 = new Comment("Grace", "I can't wait to see your next video!");

        video2.AddComment(comment5, video2);
        video2.AddComment(comment6, video2);
        video2.AddComment(comment7, video2);

        video2.DisplayVideoInfo();

        Video video3 = new Video("My Third Video", "Alice Johnson", 240);
        Comment comment8 = new Comment("Hannah", "This video was very helpful.");
        Comment comment9 = new Comment("Ian", "I learned a lot from this video.");
        Comment comment10 = new Comment("Jack", "Great content!");

        video3.AddComment(comment8, video3);
        video3.AddComment(comment9, video3);
        video3.AddComment(comment10, video3);

        video3.DisplayVideoInfo();

        Video video4 = new Video("My Fourth Video", "Bob Brown", 300);
        Comment comment11 = new Comment("Karen", "This video was very informative.");
        Comment comment12 = new Comment("Leo", "I appreciate the effort you put into this video.");
        Comment comment13 = new Comment("Mia", "I can't wait to see your next video!");

        video4.AddComment(comment11, video4);
        video4.AddComment(comment12, video4);
        video4.AddComment(comment13, video4);

        video4.DisplayVideoInfo();
        
    }
}