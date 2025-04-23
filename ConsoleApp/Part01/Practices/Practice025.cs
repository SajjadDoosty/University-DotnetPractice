namespace DotnetPractice.Part01.Practices;

public static class Practice025
{
	public static void Run()
	{
		Console.Write("Enter number to show prime number's of Fibonacci: ");
		var number = Convert.ToInt32(Console.ReadLine());

		int sum = 1;

		int recentNumber = 0;

		Console.WriteLine("0");

		while (sum <= number)
		{
			if (sum.IsPrimee())
			{
				Console.WriteLine(sum);
			}

			int temp = sum;

			sum += recentNumber;

			recentNumber = temp;
		}
	}

	private static bool IsPrimee(this int number)
	{
		bool isPrime = true;

		for (int i = 2; i < number; i++)
		{
			if (number % i == 0)
			{
				isPrime = false;
				break;
			}
		}

		return isPrime;
	}
}