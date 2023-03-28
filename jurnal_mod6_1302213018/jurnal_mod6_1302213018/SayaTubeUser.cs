using System;
using System.Diagnostics;

public class SayaTubeUser
{
    int id;
    List<SayaTubeVideo> uploadedVideos;
    string Username;

    public SayaTubeUser(string username)
    {
        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (SayaTubeVideo video in uploadedVideos)
        {
            total += video.GetPlayCount();
        }
        return total;
    }

    public void AddVideo(SayaTubeVideo sayaTubeVideo)
    {
        Debug.Assert(sayaTubeVideo != null);
        Debug.Assert(sayaTubeVideo.GetPlayCount() < 1000000000000);
        this.uploadedVideos.Add(sayaTubeVideo);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User : " + this.Username);
        for (int i = 0; i < GetTotalVideoPlayCount(); i++)
        {
            Console.WriteLine("Video " + (i + 1) + " Judul: " + uploadedVideos[i] + " Count " + uploadedVideos[i].GetPlayCount());
        }
    }
}
