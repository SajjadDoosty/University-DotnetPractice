namespace DotnetPractice.Practices;

public static class Practice003
{
	public static void Run()
	{
		Console.Write("Enter count of number's: ");

		var count = Convert.ToInt32(Console.ReadLine());

		int sum = 0;

		for (int i = 0; i < count; i++)
		{
			var number = Convert.ToInt32(Console.ReadLine());

			sum += number;
		}

		var result = (double)sum / count;

		Console.WriteLine(result);
	}
}