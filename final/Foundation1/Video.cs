using System;
using System.Collections.Generic;
using System.IO;

public class Video
{
    // Properties
    private string _title;
    private string _author;
    private string _length;
    private int _numberOfComments;
    private List<Comment> _comments;

    // Constructor
    public Video(string title, string author, string length, int numberOfComments, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _numberOfComments = numberOfComments;
        _comments = comments;
    }

    // Static method to read videos from a file and return a list of Video objects
    public static List<Video> LoadVideosFromFile(string _fileName)
    {
        List<Video> videos = new List<Video>();
        Video currentVideo = null;

        try
        {
            if (File.Exists(_fileName))
            {
                string[] lines = File.ReadAllLines(_fileName);

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                    {
                        continue; // Skip empty lines
                    }

                    if (!line.StartsWith("@"))
                    {
                        // This is a video line
                        string[] parts = line.Split('|');
                        if (parts.Length == 5)
                        {
                            string title = parts[0].Trim();
                            string author = parts[1].Trim();
                            string length = parts[2].Trim();
                            int numberOfComments = int.Parse(parts[3].Trim());

                            currentVideo = new Video(title, author, length, numberOfComments, new List<Comment>());
                            videos.Add(currentVideo);
                        }
                    }
                    else
                    {
                        // This is a comment line
                        if (currentVideo != null)
                        {
                            string[] commentParts = line.Split(new string[] { " ~ " }, StringSplitOptions.None);
                            if (commentParts.Length == 2)
                            {
                                string username = commentParts[0].Trim();
                                string text = commentParts[1].Trim();
                                currentVideo._comments.Add(new Comment(username, text));
                            }
                        }
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
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length}");
            Console.WriteLine($"Number of Comments: {video._numberOfComments}");
            Console.WriteLine("Comments:");
            foreach (var comment in video._comments)
            {
                Console.WriteLine(comment.ToString());
            }
            Console.WriteLine();
        }

        Console.WriteLine("Videos displayed successfully.");
    }
}
