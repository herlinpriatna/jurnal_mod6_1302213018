class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video1 = new SayaTubeVideo("Review Film Habibie & Ainun 1 oleh Herlin Priatna");
        SayaTubeVideo video2 = new SayaTubeVideo("Review Film Habibie & Ainun 2 oleh Herlin Priatna");
        SayaTubeVideo video3 = new SayaTubeVideo("Review Film Habibie & Ainun 3 oleh Herlin Priatna");
        SayaTubeVideo video4 = new SayaTubeVideo("Review Film Habibie & Ainun 4 oleh Herlin Priatna");
        SayaTubeVideo video5 = new SayaTubeVideo("Review Film Habibie & Ainun 5 oleh Herlin Priatna");
        SayaTubeVideo video6 = new SayaTubeVideo("Review Film Habibie & Ainun 6 oleh Herlin Priatna");
        SayaTubeVideo video7 = new SayaTubeVideo("Review Film Habibie & Ainun 7 oleh Herlin Priatna");
        SayaTubeVideo video8 = new SayaTubeVideo("Review Film Habibie & Ainun 8 oleh Herlin Priatna");
        SayaTubeVideo video9 = new SayaTubeVideo("Review Film Habibie & Ainun 9 oleh Herlin Priatna");
        SayaTubeVideo video10 = new SayaTubeVideo("Review Film Habibie & Ainun 10 oleh Herlin Priatna");

        video1.IncreasePlayCount(10000);
        video2.IncreasePlayCount(20000);
        video3.IncreasePlayCount(30000);
        video4.IncreasePlayCount(40000);
        video5.IncreasePlayCount(10000);
        video6.IncreasePlayCount(20000);
        video7.IncreasePlayCount(30000);
        video8.IncreasePlayCount(40000);
        video9.IncreasePlayCount(50000);
        video10.IncreasePlayCount(20000);

        video1.PrintVideoDetails();
        video2.PrintVideoDetails();
        video3.PrintVideoDetails();
        video4.PrintVideoDetails();
        video5.PrintVideoDetails();
        video6.PrintVideoDetails();
        video7.PrintVideoDetails();
        video8.PrintVideoDetails();
        video9.PrintVideoDetails();
        video10.PrintVideoDetails();

        Console.WriteLine();
        SayaTubeUser user1 = new SayaTubeUser("Herlin Priatna");

        user1.AddVideo(video1);
        user1.AddVideo(video2);
        user1.AddVideo(video3);
        user1.AddVideo(video4);
        user1.AddVideo(video5);
        user1.AddVideo(video6);
        user1.AddVideo(video7);
        user1.AddVideo(video8);

        user1.PrintAllVideoPlayCount();
    }
    
}