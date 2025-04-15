namespace DotnetPractice.Practices;

public static class Practice002
{
	public static void Run()
	{
		Console.Write("Enter count of number's: ");

		var count = Convert.ToInt32(Console.ReadLine());

		int maxNumber = 0;

		for (int i = 0; i < count; i++)
		{
			var number = Convert.ToInt32(Console.ReadLine());

			if (i == 0)
			{
				maxNumber = number;
				continue;
			}

			if (number > maxNumber)
			{
				maxNumber = number;
			}
		}

		Console.WriteLine(maxNumber);
	}
}