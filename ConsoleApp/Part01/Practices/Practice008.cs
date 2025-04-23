namespace DotnetPractice.Part01.Practices;

public static class Practice008
{
	public static void Run()
	{
		Console.Write("Enter number: ");

		var number = Convert.ToInt32(Console.ReadLine());

		bool isPrime = true;

		for (int i = 2; i < number; i++)
		{
			if (number % i == 0)
			{
				isPrime = false;
				break;
			}
		}

		Console.WriteLine(isPrime ? "Is Prime!" : "Is Not Prime!");
	}
}