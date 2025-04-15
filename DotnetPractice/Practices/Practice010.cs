namespace DotnetPractice.Practices;

public static class Practice010
{
	public static void Run()
	{
		for (int i = 1000; i <= 9999; i++)
		{
			var numberString = i.ToString();

			if (numberString[0] == numberString[3] && numberString[1] == numberString[2])
			{
				Console.WriteLine(i);
			}
		}
	}
}