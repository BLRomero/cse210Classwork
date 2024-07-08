using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Specify the file name
        string fileName = "YoutubeVideos.txt";

        // Load videos from the file
        List<Video> videos = Video.LoadVideosFromFile(fileName);

        // Display the loaded videos
        Video.DisplayVideos(videos);
    }
}
