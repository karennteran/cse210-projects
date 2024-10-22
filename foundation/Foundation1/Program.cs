class Program
{
    static void Main(string[] args)
    {
        // Create some videos
        Video video1 = new Video("Learn C# in 10 minutes", "John Doe", 600);
        Video video2 = new Video("Cooking 101: Simple Pasta", "Jane Smith", 900);
        Video video3 = new Video("Amazing Nature Documentary", "David Attenborough", 3600);

        // Add comments to video 1
        video1.AddComment(new Comment("Alice", "This video was super helpful!"));
        video1.AddComment(new Comment("Bob", "Great introduction to C#!"));
        video1.AddComment(new Comment("Charlie", "I learned a lot, thanks!"));

        // Add comments to video 2
        video2.AddComment(new Comment("Eve", "The recipe worked perfectly."));
        video2.AddComment(new Comment("Mallory", "Easy to follow, I loved it!"));
        video2.AddComment(new Comment("Oscar", "Best pasta I've made!"));

        // Add comments to video 3
        video3.AddComment(new Comment("Trudy", "This documentary was stunning."));
        video3.AddComment(new Comment("Victor", "Incredible footage, so beautiful."));
        video3.AddComment(new Comment("Wendy", "I felt like I was there in nature!"));

        // Store the videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
