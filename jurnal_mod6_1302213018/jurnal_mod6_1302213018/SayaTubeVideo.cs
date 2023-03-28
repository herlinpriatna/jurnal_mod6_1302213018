using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
	int id;
	public string title;
	int playCount;
	public SayaTubeVideo(string title)
	{
		Random rnd = new Random();
		this.id = rnd.Next(10000, 99999);
		Contract.Requires(title.Length < 200);
		Contract.Requires(title != null);
		this.title = title;
		this.playCount = 0;
	}

	public void IncreasePlayCount(int playCount)
	{
		Contract.Requires(playCount <= 25000000);
		try
		{
			this.playCount = checked(this.playCount + playCount);
		} catch (OverflowException) {
			Console.WriteLine("jumlah play count melebihi batas tertinggi");
		}
		
		this.playCount += playCount;
	}

	public void PrintVideoDetails()
	{
		Console.WriteLine("ID Video: " + this.id);
		Console.WriteLine("Judul : " + this.title);
		Console.WriteLine("Play count : " + this.playCount);
		Console.WriteLine();
	}

	public int GetPlayCount()
	{
		return this.playCount;
	}
}
