namespace DotnetPractice.Practices;

public static class Practice012
{
	public static void Run()
	{
		Console.Write("Enter number of N: ");

		var nNumber = Convert.ToInt32(Console.ReadLine());

		double sum = 0;

		for (int i = 1; i <= nNumber; i++)
		{
			sum += (double)1 / i;
		}

		Console.WriteLine(sum);
	}
}