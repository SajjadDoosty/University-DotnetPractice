namespace DotnetPractice.Part01.Practices;

public static class Practice026
{
	public static void Run()
	{
		Console.Write("Enter number: ");
		var number = Convert.ToInt32(Console.ReadLine());

		int sum = 0;

		for (int i = 0; i < number.ToString().Length; i++)
		{
			sum += Convert.ToInt32(number.ToString()[i].ToString()).Factorial();
		}

		if (sum == number)
		{
			Console.WriteLine($"{number} is strong number!");
		}
		else
		{
			Console.WriteLine($"{number} is NOT strong number!");
		}
	}

	private static int Factorial(this int number)
	{
		int sum = 1;

		for (int i = 1; i <= number; i++)
		{
			sum *= i;
		}

		return sum;
	}
}