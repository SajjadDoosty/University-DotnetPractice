namespace DotnetPractice.Practices;

public static class Practice021
{
	public static void Run()
	{
		for (int i = 1000; i <= 9999; i++)
		{
			if (Convert.ToInt32((i.ToString()[0]).ToString()) % 2 != 0 &&
				Convert.ToInt32((i.ToString()[2]).ToString()) % 2 != 0 &&
				Convert.ToInt32((i.ToString()[1]).ToString()) % 2 == 0 &&
				Convert.ToInt32((i.ToString()[3]).ToString()) % 2 == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}