
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("Floating Islands of Lake Titicaca", "Kara Sierra", 14);

        Comment video1Comment1 = new Comment("Bharat", "Island is amazing and beautiful views .Love from Ghaziabad Indian and God bless you all.");
        Comment video1Comment2 = new Comment("Sathish", "Mate, I visited Lake Titicaca some years back and it was awesome.");
        Comment video1Comment3 = new Comment("Bruce", "I like your travelling style. Content is not a clickbait and drone shots are really good.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("What happens in a Carnival in Copacabana", "Punjabi Wanderer", 16);

        Comment video2Comment1 = new Comment("Ali", "Amazing covering with fun and colourful music and beautiful dancing.");
        Comment video2Comment2 = new Comment("Shantal", "I like how careful you are with people offering to go somewhere or stay up late.");
        Comment video2Comment3 = new Comment("Irina", "You actually showing us how beautiful the world actually is. Wish you luck for all coming events.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Uyuni Bolivia Uncovered. What No One Tells You", "Tide Knot", 8);

        Comment video3Comment1 = new Comment("Kayla", "I want to go to Uyuni so bad. It looks so amazing! Looks like you had an amazing bucket list trip!");
        Comment video3Comment2 = new Comment("Nicole", "Wow. What an adventure! I love what you said about being kind to working people!!");
        Comment video3Comment3 = new Comment("Peter", "I have been living in Bolivia as an expat for about 2 years now and I still have not had a chance to visit Uyuni.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayVideoInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}