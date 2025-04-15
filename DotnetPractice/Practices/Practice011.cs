namespace DotnetPractice.Practices;

public static class Practice011
{
	public static void Run()
	{
		Console.Write("Enter number: ");

		var number = Convert.ToInt32(Console.ReadLine());

		int sum = 1;

		for (int i = 2; i <= number; i++)
		{
			if (i % 2 == 0)
			{
				sum += i;
			}
			else
			{
				sum -= i;
			}
		}

		Console.WriteLine(sum);
	}
}