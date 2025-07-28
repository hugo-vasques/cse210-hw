using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("How to craft a crafting table!! 2025", "minecraftLeg0dude", 160);
        video1.AddComment(new Comment("Vegetta777", "Nice! Now I'm able to craft my furnances!"));
        video1.AddComment(new Comment("JH145", "It worked thanks! New sub btw"));
        video1.AddComment(new Comment("Em157", "Yoo it didn't work :("));
        videos.Add(video1);

        Video video2 = new Video("I'll save you 10 years of C# with this video", "EasyTech", 300);
        video2.AddComment(new Comment("Robloxian123", "Get free robux clicking on this link: https://robux.free/.com"));
        video2.AddComment(new Comment("george_canister", "I watch it more than twice and I still don't understand lol"));
        video2.AddComment(new Comment("DJ_Booth15", "You just skipped a lot of concepts and suggested everytime to buy your course, dislike"));
        videos.Add(video2);

        Video video3 = new Video("How to fry an egg! (Updated)", "HowToBasic", 180);
        video3.AddComment(new Comment("DaRealOne", "Really helpful, now I'll do it every breakfast!"));
        video3.AddComment(new Comment("SaintIllana", "Ughh the pan was to hot and the egg got sticked to it :'v"));
        video3.AddComment(new Comment("mark_INVINciblE", "Does anyone want to chat with me?"));
        videos.Add(video3);

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v.Title}");
            Console.WriteLine($"Author: {v.Author}");
            Console.WriteLine($"Length: {v.Length}");
            Console.WriteLine($"Comments: ({v.GetCommentCount()}):");

            foreach (Comment c in v.GetComments())
            {
                Console.WriteLine($"    - {c.Name}: {c.Text}");
            }

            Console.WriteLine();
        }
    }
}