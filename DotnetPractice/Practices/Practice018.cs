namespace DotnetPractice.Practices;

public static class Practice018
{
	public static void Run()
	{
		for (int i = 1; ; i++)
		{
			int numberTwo = 2 * i;
			int numberFive = 5 * i;

			Console.WriteLine("Number 2: {0}, Number 5: {1}",
				numberTwo <= 1000 ? numberTwo : "End",
				numberFive <= 1000 ? numberFive : "End");

			if (numberTwo > 1000 && numberFive > 1000)
			{
				break;
			}
		}
	}
}