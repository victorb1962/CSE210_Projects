using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Video video = new Video("It's Beginning to Look a Lot Like Christmas", "Michael Bublé", "207 seconds");
        video.VideoInfo();
        video.AddComment("@Jarod-vg9wq", "It’s not Christmas until Micheal buble sings!");
        video.AddComment("@MelodyLines-232", "Aa gentle Christmas song, warm melody");
        video.Comments();

        Video video2 = new Video("Let It Snow! Let It Snow! Let It Snow!", "Dean Martin", "116 seconds");
        video2.VideoInfo();
        video2.AddComment("@TheKlause", "Ho! Ho! Ho! Can’t do the holidays without Dean O");
        video2.AddComment("@julianarezk1106", "Let it snow let it snow let it snow");
        video2.AddComment("@tokyoseclipse8908", "I wish dean martin was still alive i loved all his music");
        video2.Comments();

        Video video3 = new Video("Have Yourself A Merry Little Christmas ", "Frank Sinatra", "215 seconds");
        video3.VideoInfo();
        video3.AddComment("@DosisdeCultura", "Thank you for sharing our reality");
        video3.AddComment("@stellamorris6367", "This reminds me of my dad who passed from cancer in 1994.");
        video3.AddComment("@blindingmule7355", "I love that every Christmas there's a new Frank Sinatra's animated video");
        video3.AddComment("@PeytonMorris-h6p", "Something about hearing Franks music during Christmas season just takes me to a nostalgic place.");
        video3.Comments();
    }
}