using System;
using System.Collections.Generic;
using System.IO;

public class Video
{
    // Properties
    public string Title { get; set; }
    public string Author { get; set; }
    public string Length { get; set; }
    public int NumberOfComments { get; set; }
    public List<Comment> Comments { get; set; }

    // Constructor
    public Video(string title, string author, string length, int numberOfComments, List<Comment> comments)
    {
        Title = title;
        Author = author;
        Length = length;
        NumberOfComments = numberOfComments;
        Comments = comments;
    }

    // Static method to read videos from a file and return a list of Video objects
    public static List<Video> LoadVideosFromFile(string fileName)
    {
        List<Video> videos = new List<Video>();

        try
        {
            if (File.Exists(fileName))
            {
                string[] lines = File.ReadAllLines(fileName);

                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 5)
                    {
                        string title = parts[0].Trim();
                        string author = parts[1].Trim();
                        string length = parts[2].Trim();
                        int numberOfComments = int.Parse(parts[3].Trim());
                        string listOfComments = parts[4].Trim();

                        List<Comment> comments = new List<Comment>();
                        string[] commentParts = listOfComments.Split('~');
                        foreach (var commentPart in commentParts)
                        {
                            if (!string.IsNullOrWhiteSpace(commentPart))
                            {
                                string[] commentDetails = commentPart.Split(new string[] { " ~ " }, StringSplitOptions.None);
                                if (commentDetails.Length == 2)
                                {
                                    string username = commentDetails[0].Trim();
                                    string text = commentDetails[1].Trim();
                                    comments.Add(new Comment(username, text));
                                }
                            }
                        }

                        Video video = new Video(title, author, length, numberOfComments, comments);
                        videos.Add(video);
                    }
                }
            }
            else
            {
                Console.WriteLine("Video file not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading Videos: {ex.Message}");
        }

        return videos;
    }

    // Static method to display a list of Video objects
    public static void DisplayVideos(List<Video> videos)
    {
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length}");
            Console.WriteLine($"Number of Comments: {video.NumberOfComments}");
            Console.WriteLine("Comments:");
            foreach (var comment in video.Comments)
            {
                Console.WriteLine(comment.ToString());
            }
            Console.WriteLine();
        }

        Console.WriteLine("Videos displayed successfully.");
    }
}
