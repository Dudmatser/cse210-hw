using System;

class Program
{
    static void Main(string[] args)
    {
       List<Video> videoList = new List<Video>();
        
       Video v1 = new Video();
       v1._title = "$1 Vs $100,000,000 House!";
       v1._author = "Mrbeast";
       v1._lenght = 18;

       Comment comment1v1 = new Comment();
       comment1v1._name = "proking965";
       comment1v1._text = "Huge props to the editors and designers the set was spot on";

       Comment comment2v1 = new Comment("JamalAlpha", "The 30M$ house was undoubtably the most beautiful house I’ve ever seen");
       Comment comment3v1 = new Comment("JL-mp3fw", "the amount of determination and the amount of energy he puts into his vids is amazing.  Keep it up");

        v1._comments.Add(comment1v1);
        v1._comments.Add(comment2v1);
        v1._comments.Add(comment3v1);

        Video v2 = new Video("100 car batteries wired in parallel!", "styropyro", 38);
        Comment comment1v2 = new Comment("Alexander_Grant", "Well, this is exactly how I'd expect him to interact with other people. He makes two other people who do insane engineering things look completely sane.");
        Comment comment2v2 = new Comment("Odysseus1999", "Imagine being this dude’s neighbor and seeing him make portals to different dimensions in his backyard");
        Comment comment3v2 = new Comment("TannerBraungardt", "Is it time to dump all these car batteries in the ocean?!");

        v2._comments.Add(comment1v2);
        v2._comments.Add(comment2v2);
        v2._comments.Add(comment3v2);

        Video v3 = new Video("The man who tried to fake an element", "BobbyBroccoli", 60);
        Comment comment1v3 = new Comment("NileRed", "That was awesome. Definitely one of the best videos I've seen in a long time.");
        Comment comment2v3 = new Comment("griffinhewlett7308", "The idea of Seaborg living in old age with an element named after him makes me believe in happy endings");
        Comment comment3v3 = new Comment("Colorful_Chameleon", "It must've been a real roller coaster of emotions to win the Nobel Prize for the elements you discovered, then be told you didn't find new elements, only to then be told you just... exploded a whole atom.");

        v3._comments.Add(comment1v3);
        v3._comments.Add(comment2v3);
        v3._comments.Add(comment3v3);

        videoList.Add(v1);
        videoList.Add(v2);
        videoList.Add(v3);

        foreach (Video video in videoList)
        {
            Console.WriteLine(video.GetVideoDetails());
            video.GetComments();
        }
    }
}