namespace DotnetPractice.Part01.Practices;

public static class Practice022
{
	public static void Run()
	{
		Console.WriteLine("Mode's can devide 1000Coin:");

		for (int i = 0; i <= 5; i++)
		{
			for (int j = 0; j <= 10; j++)
			{
				var coins200 = 200 * i;
				var coins100 = 100 * j;

				if (coins200 + coins100 == 1000)
				{
					Console.WriteLine($"200Coin's: {i}, 100Coin's: {j}");
				}
			}
		}
	}
}