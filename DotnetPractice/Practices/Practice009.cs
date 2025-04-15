namespace DotnetPractice.Practices;

public static class Practice009
{
	public static void Run()
	{
		Console.WriteLine("Prime number's:");

		for (int i = 1; i <= 1000; i++)
		{
			bool isPrime = true;

			for (int j = 2; j < i; j++)
			{
				if (i % j == 0)
				{
					isPrime = false;
					break;
				}
			}

			if (isPrime)
			{
				Console.WriteLine(i);
			}
		}
	}
}