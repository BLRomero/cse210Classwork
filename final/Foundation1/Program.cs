using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string _fileName = "YoutubeVideos.txt";
        List<Video> videos = Video.LoadVideosFromFile(_fileName);
        Video.DisplayVideos(videos);
    }
}
