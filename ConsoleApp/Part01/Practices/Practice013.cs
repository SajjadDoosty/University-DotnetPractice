namespace DotnetPractice.Part01.Practices;

public static class Practice013
{
	public static void Run()
	{
		Console.Write("Enter number: ");

		var number = Convert.ToInt32(Console.ReadLine());

		int sum = 0;
		int count = 0;

		for (int i = 1; i <= number; i++)
		{
			if (number % i == 0)
			{
				Console.WriteLine(i);
				sum += i;
				count++;
			}
		}

		Console.WriteLine($"Count: {count}, Sum: {sum}");
	}
}