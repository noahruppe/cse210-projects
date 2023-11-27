using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Fall Out", "Mark Sanjez", 300);
        video1.AddComment("ChunkyMonkey", "Great video!");
        video1.AddComment("ThatsWhat9", "I learned a lot.");
        videos.Add(video1);

        Video video2 = new Video("Risen Civilization", "Lee Carter", 450);
        video2.AddComment("SnackleCrackle76", "Interesting topic.");
        videos.Add(video2);

        Video video3 = new Video("Jump UP", "Harvelen Jones", 240);
        video3.AddComment("SmackCrakleandpop505", "Awesome video!");
        video3.AddComment("Amandawaller34", "Helpful information.");
        video3.AddComment("Nixion05", "Looking forward to more.");
        videos.Add(video3);

        Video video4 = new Video("Attack Of The Bee's", "Leehun dyn", 360);
        video4.AddComment("SHRiek12", "Well done!");
        video4.AddComment("Wowthecow29", "I enjoyed it.");
        video4.AddComment("Smelyywathr123", "Keep it up!");
        videos.Add(video4);

        foreach (var video in videos) 
        {
            video.DisplayInfo();
            Console.WriteLine();
        }
    }
}