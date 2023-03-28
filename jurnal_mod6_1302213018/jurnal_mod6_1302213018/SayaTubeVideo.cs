using System;

public class SayaTubeVideo
{
	int id;
	string title;
	int playCount;
	public SayaTubeVideo(string title)
	{
		Random rnd = new Random();
		this.id = rnd.Next(10000, 99999);
		this.title = title;
		this.playCount = 0;
	}

	public void IncreasePlayCount(int playCount)
	{
		this.playCount += playCount;
	}

	public void PrintVideoDetails()
	{
		Console.WriteLine("ID Video: " + this.id);
		Console.WriteLine("Judul : " + this.title);
		Console.WriteLine("Play count : " + this.playCount);
	}

	public int GetPlayCount()
	{
		return this.playCount;
	}
}
